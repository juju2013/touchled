\ touch sensor 

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
