\ various misc stuff

$E000E010 constant SYSTICK-CSR \ SysTick Control and Status Register
$E000E014 constant SYSTICK-RVR \ SysTick Reload Value Register
$E000E018 constant SYSTICK-CVR \ SysTick Current Value Register


8000000 variable clock-hz  \ the system clock is 8 MHz after reset
0 variable ticks

: baud ( u -- u )  \ calculate baud rate divider, based on current clock rate
  clock-hz @ swap / ;

: 8MHz ( -- )  \ set the main clock back to 8 MHz, keep baud rate at 115200
  0 RCC-CFGR !                    \ revert to HSI @ 8 MHz, no PLL
  $81 RCC-CR !                    \ turn off HSE and PLL, power-up value
  $18 FLASH-ACR !                 \ zero flash wait, enable half-cycle access
  8000000 clock-hz !  115200 baud USART1-BRR !  \ fix console baud rate
;

: 64MHz ( -- )  \ set the main clock to 64 MHz, keep baud rate at 115200
  8MHz                            \ make sure the PLL is off
  %1110 18 lshift                 \ PLLMUL = 16 *  8/2 = 64mhz
            2 or  RCC-CFGR !      \ PLL is the system clock
  24 bit RCC-CR bis!              \ set PLLON
  begin 25 bit RCC-CR bit@ until  \ wait for PLLRDY
  64000000 clock-hz !  115200 baud USART1-BRR !  \ fix console baud rate
;

: ++ticks ( -- ) 1 ticks +! ;  \ for use as systick irq handler

: systick-hz ( u -- )  \ enable systick interrupt at given frequency
  ['] ++ticks irq-systick !
  clock-hz @ swap /  1- SYSTICK-RVR !  7 SYSTICK-CSR ! ;
: systick-hz? ( -- u ) \ derive current systick frequency from clock
  clock-hz @  SYSTICK-RVR @ 1+  / ;

: micros ( -- n )  \ return elapsed microseconds, this wraps after some 2000s
\ assumes systick is running at 1000 Hz, overhead is about 1.8 us @ 72 MHz
\ get current ticks and systick, spinloops if ticks changed while we looked
  begin ticks @ SYSTICK-CVR @ over ticks @ <> while 2drop repeat
  SYSTICK-RVR @ 1+ swap -  \ convert down-counter to remaining
  clock-hz @ 1000000 / ( ticks systicks mhz )
  / swap 1000 * + ;

: millis ( -- u )  \ return elapsed milliseconds, this wraps after 49 days
  ticks @ ;

: us ( n -- )  \ microsecond delay using a busy loop, this won't switch tasks
  2 -  \ adjust for approximate overhead of this code itself
  micros +  begin dup micros - 0< until  drop ;

: ms ( n -- )  \ millisecond delay, multi-tasker aware (may switch tasks!)
  millis +  begin millis over - 0< while pause repeat  drop ;
