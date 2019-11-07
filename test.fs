\ touch sensor experiments with bluepill
\ inlcudes

\ compiletoflash
\ include hexdump.fs
\ include io.fs
\ include pins64.fs
\ include disassembler-m3.fs
\ include svd.fs

compiletoram
\ include misc.fs
\ include nvic.fs

\ : cornerstone ( "name" -- )  \ define a flash memory cornerstone
\   <builds begin here dup flash-pagesize 1- and while 0 h, repeat
\   does>   begin dup  dup flash-pagesize 1- and while 2+   repeat  cr
\   eraseflashfrom 
\ ;

0 variable tickbegin
0 variable tickend

: tickduration ( -- u )
  tickend @ tickbegin @ -
;

: -sensor
  PB12 -exti.irq 
  40 irq.den
;

\ touch sensor isr
: isr-sensor
  micros tickend !
  -sensor
;

\ enable sensor irq
: +sensor
  PB12 +exti \ map PB12 to exti12
  PB12 
    dup +exti.irq
    dup +exti.raise
  -exti.fall
  ['] isr-sensor irq-exti10 ! \ set ISR routing to irq#40
  40 irq.en \ IRQ #
;
: wait 50 ms ;
: test
  ." Start samplig, any key to exit" cr
  begin
    +sensor
    PB12 ioc! IMODE-PULL PB12 io-mode! wait
    micros tickbegin !
    IMODE-FLOAT PB12 io-mode!
    wait
    tickduration . ." us" cr
  key? until
;

IMODE-FLOAT PB12 io-mode!

8mhz 115200 baud USART1-BRR ! 1000 systick-hz
