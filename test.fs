\ touch sensor experiments with bluepill
\ inlcudes

\ compiletoflash
\ include hexdump.fs
\ include io.fs
\ include pins64.fs
\ \ include disassembler-m3.fs
\ include svd.fs
\ include misc.fs
\ include interrupt.fs

compiletoram

include touchsensor.fs

include spi2.fs
include ws2812b.fs

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

72mhz 115200 baud USART1-BRR ! 1000 systick-hz
\ led-init

