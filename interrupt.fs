\ nRF52 NVIC words
\    Copyright (C) 2018  juju2013@github
\    BSD licensed, See LICENSE
\   standard cortex M NVIC

$E000E100 constant ISER
$E000E180 constant ICER
$E000E200 constant ISPR
$E000E280 constant ICPR
$E000E400 constant IPR0
$E000EF00 constant STIR

\ enable irq #
: irq.en ( # -- )
  dup 31 > if 
    32 - bit ISER 4 + ! 
  else
    bit ISER !
  then
;
\ disable irq #
: irq.den ( # -- )
  dup 31 > if 
    32 - bit ICER 4 + ! 
  else
    bit ICER !
  then
;

\ trigger irq #, how to clear interrupt status is this case ?
: irq ( # -- )
 STIR !
;

: &exti ( pin -- mask addr ) \ return exti mask and addresse for pin
  dup $0f and 4 /mod 2 lshift afio-exticr1 + ( pin remain addr )
  -rot swap 8 rshift swap 2 lshift lshift swap
  (                                            mask addr )
;
: +exti ( pin -- ) \ enable exti for pin
  &exti bis!
;
: -exti ( pin -- ) \ disable exti for pin
  &exti bic!
;
: extien ( pin -- )
  $0f and bit exti-imr bis!
;
: +exti.irq ( pin -- )
  $0f and bit exti-imr bis!
;
: -exti.irq ( pin -- )
  $0f and bit 
    dup exti-imr bic!
    exti-pr bis! \ clear pr
;
: +exti.evt ( pin -- )
  $0f and bit exti-emr bis!
;
: -exti.evt ( pin -- )
  $0f and bit exti-emr bic!
;
: +exti.raise ( pin -- )
  $0f and bit exti-rtsr bis!
;
: -exti.raise ( pin -- )
  $0f and bit exti-rtsr bic!
;
: +exti.fall ( pin -- )
  $0f and bit exti-ftsr bis!
;
: -exti.fall ( pin -- )
  $0f and bit exti-ftsr bic!
;
