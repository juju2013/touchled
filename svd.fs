\ Program Name: 1b.fs  for Mecrisp-Stellaris by Matthias Koch and licensed under the GPL
\ Copyright 2019 t.porter <terry@tjporter.com.au> and licensed under the BSD license.
\ This program must be loaded before memmap.fs as it provided the pretty printing legend for generic 32 bit prints
\ Also included is "bin." which prints the binary form of a number with no spaces between numbers for easy copy and pasting purposes

: b32loop. ( u -- ) \ print 32 bits in 1 bit groups
0  <#
31 0 DO 
# 32 HOLD LOOP
# #>
TYPE ;

: b32sloop. ( u -- ) \ print 32 bits in 1 bit groups
 0  <#
 31 0 DO
 # LOOP
 # #>
 TYPE ;


: 1b. ( u -- ) cr \ Label 1 bit generic groups
." 3|3|2|2|2|2|2|2|2|2|2|2|1|1|1|1|1|1|1|1|1|1|" cr
." 1|0|9|8|7|6|5|4|3|2|1|0|9|8|7|6|5|4|3|2|1|0|9|8|7|6|5|4|3|2|1|0 " cr
@ binary b32loop. decimal cr ;

: bin. cr         \ for manual operations producing easy to paste binary numbers i.e. " 10 bin. "
." 3322222222221111111111" cr
." 10987654321098765432109876543210 " cr
binary b32sloop. decimal cr ;


\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence

 compiletoflash

\ available forth template words as selected by config.xml

$A0000000 constant FSMC ( Flexible static memory controller ) 
FSMC $0 + constant FSMC-BCR1 ( SRAM/NOR-Flash chip-select control register  1 ) 
FSMC $4 + constant FSMC-BTR1 ( SRAM/NOR-Flash chip-select timing register  1 ) 
FSMC $8 + constant FSMC-BCR2 ( SRAM/NOR-Flash chip-select control register  2 ) 
FSMC $C + constant FSMC-BTR2 ( SRAM/NOR-Flash chip-select timing register  2 ) 
FSMC $10 + constant FSMC-BCR3 ( SRAM/NOR-Flash chip-select control register  3 ) 
FSMC $14 + constant FSMC-BTR3 ( SRAM/NOR-Flash chip-select timing register  3 ) 
FSMC $18 + constant FSMC-BCR4 ( SRAM/NOR-Flash chip-select control register  4 ) 
FSMC $1C + constant FSMC-BTR4 ( SRAM/NOR-Flash chip-select timing register  4 ) 
FSMC $60 + constant FSMC-PCR2 ( PC Card/NAND Flash control register  2 ) 
FSMC $64 + constant FSMC-SR2 ( FIFO status and interrupt register  2 ) 
FSMC $68 + constant FSMC-PMEM2 ( Common memory space timing register  2 ) 
FSMC $6C + constant FSMC-PATT2 ( Attribute memory space timing register  2 ) 
FSMC $74 + constant FSMC-ECCR2 ( ECC result register 2 ) 
FSMC $80 + constant FSMC-PCR3 ( PC Card/NAND Flash control register  3 ) 
FSMC $84 + constant FSMC-SR3 ( FIFO status and interrupt register  3 ) 
FSMC $88 + constant FSMC-PMEM3 ( Common memory space timing register  3 ) 
FSMC $8C + constant FSMC-PATT3 ( Attribute memory space timing register  3 ) 
FSMC $94 + constant FSMC-ECCR3 ( ECC result register 3 ) 
FSMC $A0 + constant FSMC-PCR4 ( PC Card/NAND Flash control register  4 ) 
FSMC $A4 + constant FSMC-SR4 ( FIFO status and interrupt register  4 ) 
FSMC $A8 + constant FSMC-PMEM4 ( Common memory space timing register  4 ) 
FSMC $AC + constant FSMC-PATT4 ( Attribute memory space timing register  4 ) 
FSMC $B0 + constant FSMC-PIO4 ( I/O space timing register 4 ) 
FSMC $104 + constant FSMC-BWTR1 ( SRAM/NOR-Flash write timing registers  1 ) 
FSMC $10C + constant FSMC-BWTR2 ( SRAM/NOR-Flash write timing registers  2 ) 
FSMC $114 + constant FSMC-BWTR3 ( SRAM/NOR-Flash write timing registers  3 ) 
FSMC $11C + constant FSMC-BWTR4 ( SRAM/NOR-Flash write timing registers  4 ) 
: FSMC-BCR1. ." FSMC-BCR1 (read-write) $" FSMC-BCR1 @ hex. FSMC-BCR1 1b. ;
: FSMC-BTR1. ." FSMC-BTR1 (read-write) $" FSMC-BTR1 @ hex. FSMC-BTR1 1b. ;
: FSMC-BCR2. ." FSMC-BCR2 (read-write) $" FSMC-BCR2 @ hex. FSMC-BCR2 1b. ;
: FSMC-BTR2. ." FSMC-BTR2 (read-write) $" FSMC-BTR2 @ hex. FSMC-BTR2 1b. ;
: FSMC-BCR3. ." FSMC-BCR3 (read-write) $" FSMC-BCR3 @ hex. FSMC-BCR3 1b. ;
: FSMC-BTR3. ." FSMC-BTR3 (read-write) $" FSMC-BTR3 @ hex. FSMC-BTR3 1b. ;
: FSMC-BCR4. ." FSMC-BCR4 (read-write) $" FSMC-BCR4 @ hex. FSMC-BCR4 1b. ;
: FSMC-BTR4. ." FSMC-BTR4 (read-write) $" FSMC-BTR4 @ hex. FSMC-BTR4 1b. ;
: FSMC-PCR2. ." FSMC-PCR2 (read-write) $" FSMC-PCR2 @ hex. FSMC-PCR2 1b. ;
: FSMC-SR2. ." FSMC-SR2 () $" FSMC-SR2 @ hex. FSMC-SR2 1b. ;
: FSMC-PMEM2. ." FSMC-PMEM2 (read-write) $" FSMC-PMEM2 @ hex. FSMC-PMEM2 1b. ;
: FSMC-PATT2. ." FSMC-PATT2 (read-write) $" FSMC-PATT2 @ hex. FSMC-PATT2 1b. ;
: FSMC-ECCR2. ." FSMC-ECCR2 (read-only) $" FSMC-ECCR2 @ hex. FSMC-ECCR2 1b. ;
: FSMC-PCR3. ." FSMC-PCR3 (read-write) $" FSMC-PCR3 @ hex. FSMC-PCR3 1b. ;
: FSMC-SR3. ." FSMC-SR3 () $" FSMC-SR3 @ hex. FSMC-SR3 1b. ;
: FSMC-PMEM3. ." FSMC-PMEM3 (read-write) $" FSMC-PMEM3 @ hex. FSMC-PMEM3 1b. ;
: FSMC-PATT3. ." FSMC-PATT3 (read-write) $" FSMC-PATT3 @ hex. FSMC-PATT3 1b. ;
: FSMC-ECCR3. ." FSMC-ECCR3 (read-only) $" FSMC-ECCR3 @ hex. FSMC-ECCR3 1b. ;
: FSMC-PCR4. ." FSMC-PCR4 (read-write) $" FSMC-PCR4 @ hex. FSMC-PCR4 1b. ;
: FSMC-SR4. ." FSMC-SR4 () $" FSMC-SR4 @ hex. FSMC-SR4 1b. ;
: FSMC-PMEM4. ." FSMC-PMEM4 (read-write) $" FSMC-PMEM4 @ hex. FSMC-PMEM4 1b. ;
: FSMC-PATT4. ." FSMC-PATT4 (read-write) $" FSMC-PATT4 @ hex. FSMC-PATT4 1b. ;
: FSMC-PIO4. ." FSMC-PIO4 (read-write) $" FSMC-PIO4 @ hex. FSMC-PIO4 1b. ;
: FSMC-BWTR1. ." FSMC-BWTR1 (read-write) $" FSMC-BWTR1 @ hex. FSMC-BWTR1 1b. ;
: FSMC-BWTR2. ." FSMC-BWTR2 (read-write) $" FSMC-BWTR2 @ hex. FSMC-BWTR2 1b. ;
: FSMC-BWTR3. ." FSMC-BWTR3 (read-write) $" FSMC-BWTR3 @ hex. FSMC-BWTR3 1b. ;
: FSMC-BWTR4. ." FSMC-BWTR4 (read-write) $" FSMC-BWTR4 @ hex. FSMC-BWTR4 1b. ;
: FSMC.
FSMC-BCR1.
FSMC-BTR1.
FSMC-BCR2.
FSMC-BTR2.
FSMC-BCR3.
FSMC-BTR3.
FSMC-BCR4.
FSMC-BTR4.
FSMC-PCR2.
FSMC-SR2.
FSMC-PMEM2.
FSMC-PATT2.
FSMC-ECCR2.
FSMC-PCR3.
FSMC-SR3.
FSMC-PMEM3.
FSMC-PATT3.
FSMC-ECCR3.
FSMC-PCR4.
FSMC-SR4.
FSMC-PMEM4.
FSMC-PATT4.
FSMC-PIO4.
FSMC-BWTR1.
FSMC-BWTR2.
FSMC-BWTR3.
FSMC-BWTR4.
;

$40007000 constant PWR ( Power control ) 
PWR $0 + constant PWR-CR ( Power control register  PWR_CR ) 
PWR $4 + constant PWR-CSR ( Power control register  PWR_CR ) 
: PWR-CR. ." PWR-CR (read-write) $" PWR-CR @ hex. PWR-CR 1b. ;
: PWR-CSR. ." PWR-CSR () $" PWR-CSR @ hex. PWR-CSR 1b. ;
: PWR.
PWR-CR.
PWR-CSR.
;

$40021000 constant RCC ( Reset and clock control ) 
RCC $0 + constant RCC-CR ( Clock control register ) 
RCC $4 + constant RCC-CFGR ( Clock configuration register  RCC_CFGR ) 
RCC $8 + constant RCC-CIR ( Clock interrupt register  RCC_CIR ) 
RCC $C + constant RCC-APB2RSTR ( APB2 peripheral reset register  RCC_APB2RSTR ) 
RCC $10 + constant RCC-APB1RSTR ( APB1 peripheral reset register  RCC_APB1RSTR ) 
RCC $14 + constant RCC-AHBENR ( AHB Peripheral Clock enable register  RCC_AHBENR ) 
RCC $18 + constant RCC-APB2ENR ( APB2 peripheral clock enable register  RCC_APB2ENR ) 
RCC $1C + constant RCC-APB1ENR ( APB1 peripheral clock enable register  RCC_APB1ENR ) 
RCC $20 + constant RCC-BDCR ( Backup domain control register  RCC_BDCR ) 
RCC $24 + constant RCC-CSR ( Control/status register  RCC_CSR ) 
: RCC-CR. ." RCC-CR () $" RCC-CR @ hex. RCC-CR 1b. ;
: RCC-CFGR. ." RCC-CFGR () $" RCC-CFGR @ hex. RCC-CFGR 1b. ;
: RCC-CIR. ." RCC-CIR () $" RCC-CIR @ hex. RCC-CIR 1b. ;
: RCC-APB2RSTR. ." RCC-APB2RSTR (read-write) $" RCC-APB2RSTR @ hex. RCC-APB2RSTR 1b. ;
: RCC-APB1RSTR. ." RCC-APB1RSTR (read-write) $" RCC-APB1RSTR @ hex. RCC-APB1RSTR 1b. ;
: RCC-AHBENR. ." RCC-AHBENR (read-write) $" RCC-AHBENR @ hex. RCC-AHBENR 1b. ;
: RCC-APB2ENR. ." RCC-APB2ENR (read-write) $" RCC-APB2ENR @ hex. RCC-APB2ENR 1b. ;
: RCC-APB1ENR. ." RCC-APB1ENR (read-write) $" RCC-APB1ENR @ hex. RCC-APB1ENR 1b. ;
: RCC-BDCR. ." RCC-BDCR () $" RCC-BDCR @ hex. RCC-BDCR 1b. ;
: RCC-CSR. ." RCC-CSR () $" RCC-CSR @ hex. RCC-CSR 1b. ;
: RCC.
RCC-CR.
RCC-CFGR.
RCC-CIR.
RCC-APB2RSTR.
RCC-APB1RSTR.
RCC-AHBENR.
RCC-APB2ENR.
RCC-APB1ENR.
RCC-BDCR.
RCC-CSR.
;

$40010800 constant GPIOA ( General purpose I/O ) 
GPIOA $0 + constant GPIOA-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOA $4 + constant GPIOA-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOA $8 + constant GPIOA-IDR ( Port input data register  GPIOn_IDR ) 
GPIOA $C + constant GPIOA-ODR ( Port output data register  GPIOn_ODR ) 
GPIOA $10 + constant GPIOA-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOA $14 + constant GPIOA-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOA $18 + constant GPIOA-LCKR ( Port configuration lock  register ) 
: GPIOA-CRL. ." GPIOA-CRL (read-write) $" GPIOA-CRL @ hex. GPIOA-CRL 1b. ;
: GPIOA-CRH. ." GPIOA-CRH (read-write) $" GPIOA-CRH @ hex. GPIOA-CRH 1b. ;
: GPIOA-IDR. ." GPIOA-IDR (read-only) $" GPIOA-IDR @ hex. GPIOA-IDR 1b. ;
: GPIOA-ODR. ." GPIOA-ODR (read-write) $" GPIOA-ODR @ hex. GPIOA-ODR 1b. ;
: GPIOA-BSRR. ." GPIOA-BSRR (write-only) $" GPIOA-BSRR @ hex. GPIOA-BSRR 1b. ;
: GPIOA-BRR. ." GPIOA-BRR (write-only) $" GPIOA-BRR @ hex. GPIOA-BRR 1b. ;
: GPIOA-LCKR. ." GPIOA-LCKR (read-write) $" GPIOA-LCKR @ hex. GPIOA-LCKR 1b. ;
: GPIOA.
GPIOA-CRL.
GPIOA-CRH.
GPIOA-IDR.
GPIOA-ODR.
GPIOA-BSRR.
GPIOA-BRR.
GPIOA-LCKR.
;

$40010C00 constant GPIOB ( General purpose I/O ) 
GPIOB $0 + constant GPIOB-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOB $4 + constant GPIOB-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOB $8 + constant GPIOB-IDR ( Port input data register  GPIOn_IDR ) 
GPIOB $C + constant GPIOB-ODR ( Port output data register  GPIOn_ODR ) 
GPIOB $10 + constant GPIOB-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOB $14 + constant GPIOB-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOB $18 + constant GPIOB-LCKR ( Port configuration lock  register ) 
: GPIOB-CRL. ." GPIOB-CRL (read-write) $" GPIOB-CRL @ hex. GPIOB-CRL 1b. ;
: GPIOB-CRH. ." GPIOB-CRH (read-write) $" GPIOB-CRH @ hex. GPIOB-CRH 1b. ;
: GPIOB-IDR. ." GPIOB-IDR (read-only) $" GPIOB-IDR @ hex. GPIOB-IDR 1b. ;
: GPIOB-ODR. ." GPIOB-ODR (read-write) $" GPIOB-ODR @ hex. GPIOB-ODR 1b. ;
: GPIOB-BSRR. ." GPIOB-BSRR (write-only) $" GPIOB-BSRR @ hex. GPIOB-BSRR 1b. ;
: GPIOB-BRR. ." GPIOB-BRR (write-only) $" GPIOB-BRR @ hex. GPIOB-BRR 1b. ;
: GPIOB-LCKR. ." GPIOB-LCKR (read-write) $" GPIOB-LCKR @ hex. GPIOB-LCKR 1b. ;
: GPIOB.
GPIOB-CRL.
GPIOB-CRH.
GPIOB-IDR.
GPIOB-ODR.
GPIOB-BSRR.
GPIOB-BRR.
GPIOB-LCKR.
;

$40011000 constant GPIOC ( General purpose I/O ) 
GPIOC $0 + constant GPIOC-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOC $4 + constant GPIOC-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOC $8 + constant GPIOC-IDR ( Port input data register  GPIOn_IDR ) 
GPIOC $C + constant GPIOC-ODR ( Port output data register  GPIOn_ODR ) 
GPIOC $10 + constant GPIOC-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOC $14 + constant GPIOC-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOC $18 + constant GPIOC-LCKR ( Port configuration lock  register ) 
: GPIOC-CRL. ." GPIOC-CRL (read-write) $" GPIOC-CRL @ hex. GPIOC-CRL 1b. ;
: GPIOC-CRH. ." GPIOC-CRH (read-write) $" GPIOC-CRH @ hex. GPIOC-CRH 1b. ;
: GPIOC-IDR. ." GPIOC-IDR (read-only) $" GPIOC-IDR @ hex. GPIOC-IDR 1b. ;
: GPIOC-ODR. ." GPIOC-ODR (read-write) $" GPIOC-ODR @ hex. GPIOC-ODR 1b. ;
: GPIOC-BSRR. ." GPIOC-BSRR (write-only) $" GPIOC-BSRR @ hex. GPIOC-BSRR 1b. ;
: GPIOC-BRR. ." GPIOC-BRR (write-only) $" GPIOC-BRR @ hex. GPIOC-BRR 1b. ;
: GPIOC-LCKR. ." GPIOC-LCKR (read-write) $" GPIOC-LCKR @ hex. GPIOC-LCKR 1b. ;
: GPIOC.
GPIOC-CRL.
GPIOC-CRH.
GPIOC-IDR.
GPIOC-ODR.
GPIOC-BSRR.
GPIOC-BRR.
GPIOC-LCKR.
;

$40010000 constant AFIO ( Alternate function I/O ) 
AFIO $0 + constant AFIO-EVCR ( Event Control Register  AFIO_EVCR ) 
AFIO $4 + constant AFIO-MAPR ( AF remap and debug I/O configuration  register AFIO_MAPR ) 
AFIO $8 + constant AFIO-EXTICR1 ( External interrupt configuration register 1  AFIO_EXTICR1 ) 
AFIO $C + constant AFIO-EXTICR2 ( External interrupt configuration register 2  AFIO_EXTICR2 ) 
AFIO $10 + constant AFIO-EXTICR3 ( External interrupt configuration register 3  AFIO_EXTICR3 ) 
AFIO $14 + constant AFIO-EXTICR4 ( External interrupt configuration register 4  AFIO_EXTICR4 ) 
AFIO $1C + constant AFIO-MAPR2 ( AF remap and debug I/O configuration  register ) 
: AFIO-EVCR. ." AFIO-EVCR (read-write) $" AFIO-EVCR @ hex. AFIO-EVCR 1b. ;
: AFIO-MAPR. ." AFIO-MAPR () $" AFIO-MAPR @ hex. AFIO-MAPR 1b. ;
: AFIO-EXTICR1. ." AFIO-EXTICR1 (read-write) $" AFIO-EXTICR1 @ hex. AFIO-EXTICR1 1b. ;
: AFIO-EXTICR2. ." AFIO-EXTICR2 (read-write) $" AFIO-EXTICR2 @ hex. AFIO-EXTICR2 1b. ;
: AFIO-EXTICR3. ." AFIO-EXTICR3 (read-write) $" AFIO-EXTICR3 @ hex. AFIO-EXTICR3 1b. ;
: AFIO-EXTICR4. ." AFIO-EXTICR4 (read-write) $" AFIO-EXTICR4 @ hex. AFIO-EXTICR4 1b. ;
: AFIO-MAPR2. ." AFIO-MAPR2 (read-write) $" AFIO-MAPR2 @ hex. AFIO-MAPR2 1b. ;
: AFIO.
AFIO-EVCR.
AFIO-MAPR.
AFIO-EXTICR1.
AFIO-EXTICR2.
AFIO-EXTICR3.
AFIO-EXTICR4.
AFIO-MAPR2.
;

$40010400 constant EXTI ( EXTI ) 
EXTI $0 + constant EXTI-IMR ( Interrupt mask register  EXTI_IMR ) 
EXTI $4 + constant EXTI-EMR ( Event mask register EXTI_EMR ) 
EXTI $8 + constant EXTI-RTSR ( Rising Trigger selection register  EXTI_RTSR ) 
EXTI $C + constant EXTI-FTSR ( Falling Trigger selection register  EXTI_FTSR ) 
EXTI $10 + constant EXTI-SWIER ( Software interrupt event register  EXTI_SWIER ) 
EXTI $14 + constant EXTI-PR ( Pending register EXTI_PR ) 
: EXTI-IMR. ." EXTI-IMR (read-write) $" EXTI-IMR @ hex. EXTI-IMR 1b. ;
: EXTI-EMR. ." EXTI-EMR (read-write) $" EXTI-EMR @ hex. EXTI-EMR 1b. ;
: EXTI-RTSR. ." EXTI-RTSR (read-write) $" EXTI-RTSR @ hex. EXTI-RTSR 1b. ;
: EXTI-FTSR. ." EXTI-FTSR (read-write) $" EXTI-FTSR @ hex. EXTI-FTSR 1b. ;
: EXTI-SWIER. ." EXTI-SWIER (read-write) $" EXTI-SWIER @ hex. EXTI-SWIER 1b. ;
: EXTI-PR. ." EXTI-PR (read-write) $" EXTI-PR @ hex. EXTI-PR 1b. ;
: EXTI.
EXTI-IMR.
EXTI-EMR.
EXTI-RTSR.
EXTI-FTSR.
EXTI-SWIER.
EXTI-PR.
;

$40020000 constant DMA1 ( DMA controller ) 
DMA1 $0 + constant DMA1-ISR ( DMA interrupt status register  DMA_ISR ) 
DMA1 $4 + constant DMA1-IFCR ( DMA interrupt flag clear register  DMA_IFCR ) 
DMA1 $8 + constant DMA1-CCR1 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $C + constant DMA1-CNDTR1 ( DMA channel 1 number of data  register ) 
DMA1 $10 + constant DMA1-CPAR1 ( DMA channel 1 peripheral address  register ) 
DMA1 $14 + constant DMA1-CMAR1 ( DMA channel 1 memory address  register ) 
DMA1 $1C + constant DMA1-CCR2 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $20 + constant DMA1-CNDTR2 ( DMA channel 2 number of data  register ) 
DMA1 $24 + constant DMA1-CPAR2 ( DMA channel 2 peripheral address  register ) 
DMA1 $28 + constant DMA1-CMAR2 ( DMA channel 2 memory address  register ) 
DMA1 $30 + constant DMA1-CCR3 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $34 + constant DMA1-CNDTR3 ( DMA channel 3 number of data  register ) 
DMA1 $38 + constant DMA1-CPAR3 ( DMA channel 3 peripheral address  register ) 
DMA1 $3C + constant DMA1-CMAR3 ( DMA channel 3 memory address  register ) 
DMA1 $44 + constant DMA1-CCR4 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $48 + constant DMA1-CNDTR4 ( DMA channel 4 number of data  register ) 
DMA1 $4C + constant DMA1-CPAR4 ( DMA channel 4 peripheral address  register ) 
DMA1 $50 + constant DMA1-CMAR4 ( DMA channel 4 memory address  register ) 
DMA1 $58 + constant DMA1-CCR5 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $5C + constant DMA1-CNDTR5 ( DMA channel 5 number of data  register ) 
DMA1 $60 + constant DMA1-CPAR5 ( DMA channel 5 peripheral address  register ) 
DMA1 $64 + constant DMA1-CMAR5 ( DMA channel 5 memory address  register ) 
DMA1 $6C + constant DMA1-CCR6 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $70 + constant DMA1-CNDTR6 ( DMA channel 6 number of data  register ) 
DMA1 $74 + constant DMA1-CPAR6 ( DMA channel 6 peripheral address  register ) 
DMA1 $78 + constant DMA1-CMAR6 ( DMA channel 6 memory address  register ) 
DMA1 $80 + constant DMA1-CCR7 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $84 + constant DMA1-CNDTR7 ( DMA channel 7 number of data  register ) 
DMA1 $88 + constant DMA1-CPAR7 ( DMA channel 7 peripheral address  register ) 
DMA1 $8C + constant DMA1-CMAR7 ( DMA channel 7 memory address  register ) 
: DMA1-ISR. ." DMA1-ISR (read-only) $" DMA1-ISR @ hex. DMA1-ISR 1b. ;
: DMA1-IFCR. ." DMA1-IFCR (write-only) $" DMA1-IFCR @ hex. DMA1-IFCR 1b. ;
: DMA1-CCR1. ." DMA1-CCR1 (read-write) $" DMA1-CCR1 @ hex. DMA1-CCR1 1b. ;
: DMA1-CNDTR1. ." DMA1-CNDTR1 (read-write) $" DMA1-CNDTR1 @ hex. DMA1-CNDTR1 1b. ;
: DMA1-CPAR1. ." DMA1-CPAR1 (read-write) $" DMA1-CPAR1 @ hex. DMA1-CPAR1 1b. ;
: DMA1-CMAR1. ." DMA1-CMAR1 (read-write) $" DMA1-CMAR1 @ hex. DMA1-CMAR1 1b. ;
: DMA1-CCR2. ." DMA1-CCR2 (read-write) $" DMA1-CCR2 @ hex. DMA1-CCR2 1b. ;
: DMA1-CNDTR2. ." DMA1-CNDTR2 (read-write) $" DMA1-CNDTR2 @ hex. DMA1-CNDTR2 1b. ;
: DMA1-CPAR2. ." DMA1-CPAR2 (read-write) $" DMA1-CPAR2 @ hex. DMA1-CPAR2 1b. ;
: DMA1-CMAR2. ." DMA1-CMAR2 (read-write) $" DMA1-CMAR2 @ hex. DMA1-CMAR2 1b. ;
: DMA1-CCR3. ." DMA1-CCR3 (read-write) $" DMA1-CCR3 @ hex. DMA1-CCR3 1b. ;
: DMA1-CNDTR3. ." DMA1-CNDTR3 (read-write) $" DMA1-CNDTR3 @ hex. DMA1-CNDTR3 1b. ;
: DMA1-CPAR3. ." DMA1-CPAR3 (read-write) $" DMA1-CPAR3 @ hex. DMA1-CPAR3 1b. ;
: DMA1-CMAR3. ." DMA1-CMAR3 (read-write) $" DMA1-CMAR3 @ hex. DMA1-CMAR3 1b. ;
: DMA1-CCR4. ." DMA1-CCR4 (read-write) $" DMA1-CCR4 @ hex. DMA1-CCR4 1b. ;
: DMA1-CNDTR4. ." DMA1-CNDTR4 (read-write) $" DMA1-CNDTR4 @ hex. DMA1-CNDTR4 1b. ;
: DMA1-CPAR4. ." DMA1-CPAR4 (read-write) $" DMA1-CPAR4 @ hex. DMA1-CPAR4 1b. ;
: DMA1-CMAR4. ." DMA1-CMAR4 (read-write) $" DMA1-CMAR4 @ hex. DMA1-CMAR4 1b. ;
: DMA1-CCR5. ." DMA1-CCR5 (read-write) $" DMA1-CCR5 @ hex. DMA1-CCR5 1b. ;
: DMA1-CNDTR5. ." DMA1-CNDTR5 (read-write) $" DMA1-CNDTR5 @ hex. DMA1-CNDTR5 1b. ;
: DMA1-CPAR5. ." DMA1-CPAR5 (read-write) $" DMA1-CPAR5 @ hex. DMA1-CPAR5 1b. ;
: DMA1-CMAR5. ." DMA1-CMAR5 (read-write) $" DMA1-CMAR5 @ hex. DMA1-CMAR5 1b. ;
: DMA1-CCR6. ." DMA1-CCR6 (read-write) $" DMA1-CCR6 @ hex. DMA1-CCR6 1b. ;
: DMA1-CNDTR6. ." DMA1-CNDTR6 (read-write) $" DMA1-CNDTR6 @ hex. DMA1-CNDTR6 1b. ;
: DMA1-CPAR6. ." DMA1-CPAR6 (read-write) $" DMA1-CPAR6 @ hex. DMA1-CPAR6 1b. ;
: DMA1-CMAR6. ." DMA1-CMAR6 (read-write) $" DMA1-CMAR6 @ hex. DMA1-CMAR6 1b. ;
: DMA1-CCR7. ." DMA1-CCR7 (read-write) $" DMA1-CCR7 @ hex. DMA1-CCR7 1b. ;
: DMA1-CNDTR7. ." DMA1-CNDTR7 (read-write) $" DMA1-CNDTR7 @ hex. DMA1-CNDTR7 1b. ;
: DMA1-CPAR7. ." DMA1-CPAR7 (read-write) $" DMA1-CPAR7 @ hex. DMA1-CPAR7 1b. ;
: DMA1-CMAR7. ." DMA1-CMAR7 (read-write) $" DMA1-CMAR7 @ hex. DMA1-CMAR7 1b. ;
: DMA1.
DMA1-ISR.
DMA1-IFCR.
DMA1-CCR1.
DMA1-CNDTR1.
DMA1-CPAR1.
DMA1-CMAR1.
DMA1-CCR2.
DMA1-CNDTR2.
DMA1-CPAR2.
DMA1-CMAR2.
DMA1-CCR3.
DMA1-CNDTR3.
DMA1-CPAR3.
DMA1-CMAR3.
DMA1-CCR4.
DMA1-CNDTR4.
DMA1-CPAR4.
DMA1-CMAR4.
DMA1-CCR5.
DMA1-CNDTR5.
DMA1-CPAR5.
DMA1-CMAR5.
DMA1-CCR6.
DMA1-CNDTR6.
DMA1-CPAR6.
DMA1-CMAR6.
DMA1-CCR7.
DMA1-CNDTR7.
DMA1-CPAR7.
DMA1-CMAR7.
;

$40003800 constant SPI2 ( Serial peripheral interface ) 
SPI2 $0 + constant SPI2-CR1 ( control register 1 ) 
SPI2 $4 + constant SPI2-CR2 ( control register 2 ) 
SPI2 $8 + constant SPI2-SR ( status register ) 
SPI2 $C + constant SPI2-DR ( data register ) 
SPI2 $10 + constant SPI2-CRCPR ( CRC polynomial register ) 
SPI2 $14 + constant SPI2-RXCRCR ( RX CRC register ) 
SPI2 $18 + constant SPI2-TXCRCR ( TX CRC register ) 
SPI2 $1C + constant SPI2-I2SCFGR ( I2S configuration register ) 
SPI2 $20 + constant SPI2-I2SPR ( I2S prescaler register ) 
: SPI2-CR1. ." SPI2-CR1 (read-write) $" SPI2-CR1 @ hex. SPI2-CR1 1b. ;
: SPI2-CR2. ." SPI2-CR2 (read-write) $" SPI2-CR2 @ hex. SPI2-CR2 1b. ;
: SPI2-SR. ." SPI2-SR () $" SPI2-SR @ hex. SPI2-SR 1b. ;
: SPI2-DR. ." SPI2-DR (read-write) $" SPI2-DR @ hex. SPI2-DR 1b. ;
: SPI2-CRCPR. ." SPI2-CRCPR (read-write) $" SPI2-CRCPR @ hex. SPI2-CRCPR 1b. ;
: SPI2-RXCRCR. ." SPI2-RXCRCR (read-only) $" SPI2-RXCRCR @ hex. SPI2-RXCRCR 1b. ;
: SPI2-TXCRCR. ." SPI2-TXCRCR (read-only) $" SPI2-TXCRCR @ hex. SPI2-TXCRCR 1b. ;
: SPI2-I2SCFGR. ." SPI2-I2SCFGR (read-write) $" SPI2-I2SCFGR @ hex. SPI2-I2SCFGR 1b. ;
: SPI2-I2SPR. ." SPI2-I2SPR (read-write) $" SPI2-I2SPR @ hex. SPI2-I2SPR 1b. ;
: SPI2.
SPI2-CR1.
SPI2-CR2.
SPI2-SR.
SPI2-DR.
SPI2-CRCPR.
SPI2-RXCRCR.
SPI2-TXCRCR.
SPI2-I2SCFGR.
SPI2-I2SPR.
;

$40013800 constant USART1 ( Universal synchronous asynchronous receiver  transmitter ) 
USART1 $0 + constant USART1-SR ( Status register ) 
USART1 $4 + constant USART1-DR ( Data register ) 
USART1 $8 + constant USART1-BRR ( Baud rate register ) 
USART1 $C + constant USART1-CR1 ( Control register 1 ) 
USART1 $10 + constant USART1-CR2 ( Control register 2 ) 
USART1 $14 + constant USART1-CR3 ( Control register 3 ) 
USART1 $18 + constant USART1-GTPR ( Guard time and prescaler  register ) 
: USART1-SR. ." USART1-SR () $" USART1-SR @ hex. USART1-SR 1b. ;
: USART1-DR. ." USART1-DR (read-write) $" USART1-DR @ hex. USART1-DR 1b. ;
: USART1-BRR. ." USART1-BRR (read-write) $" USART1-BRR @ hex. USART1-BRR 1b. ;
: USART1-CR1. ." USART1-CR1 (read-write) $" USART1-CR1 @ hex. USART1-CR1 1b. ;
: USART1-CR2. ." USART1-CR2 (read-write) $" USART1-CR2 @ hex. USART1-CR2 1b. ;
: USART1-CR3. ." USART1-CR3 (read-write) $" USART1-CR3 @ hex. USART1-CR3 1b. ;
: USART1-GTPR. ." USART1-GTPR (read-write) $" USART1-GTPR @ hex. USART1-GTPR 1b. ;
: USART1.
USART1-SR.
USART1-DR.
USART1-BRR.
USART1-CR1.
USART1-CR2.
USART1-CR3.
USART1-GTPR.
;

$40022000 constant FLASH ( FLASH ) 
FLASH $0 + constant FLASH-ACR ( Flash access control register ) 
FLASH $4 + constant FLASH-KEYR ( Flash key register ) 
FLASH $8 + constant FLASH-OPTKEYR ( Flash option key register ) 
FLASH $C + constant FLASH-SR ( Status register ) 
FLASH $10 + constant FLASH-CR ( Control register ) 
FLASH $14 + constant FLASH-AR ( Flash address register ) 
FLASH $1C + constant FLASH-OBR ( Option byte register ) 
FLASH $20 + constant FLASH-WRPR ( Write protection register ) 
: FLASH-ACR. ." FLASH-ACR () $" FLASH-ACR @ hex. FLASH-ACR 1b. ;
: FLASH-KEYR. ." FLASH-KEYR (write-only) $" FLASH-KEYR @ hex. FLASH-KEYR 1b. ;
: FLASH-OPTKEYR. ." FLASH-OPTKEYR (write-only) $" FLASH-OPTKEYR @ hex. FLASH-OPTKEYR 1b. ;
: FLASH-SR. ." FLASH-SR () $" FLASH-SR @ hex. FLASH-SR 1b. ;
: FLASH-CR. ." FLASH-CR (read-write) $" FLASH-CR @ hex. FLASH-CR 1b. ;
: FLASH-AR. ." FLASH-AR (write-only) $" FLASH-AR @ hex. FLASH-AR 1b. ;
: FLASH-OBR. ." FLASH-OBR (read-only) $" FLASH-OBR @ hex. FLASH-OBR 1b. ;
: FLASH-WRPR. ." FLASH-WRPR (read-only) $" FLASH-WRPR @ hex. FLASH-WRPR 1b. ;
: FLASH.
FLASH-ACR.
FLASH-KEYR.
FLASH-OPTKEYR.
FLASH-SR.
FLASH-CR.
FLASH-AR.
FLASH-OBR.
FLASH-WRPR.
;

$E000E000 constant NVIC ( Nested Vectored Interrupt  Controller ) 
NVIC $4 + constant NVIC-ICTR ( Interrupt Controller Type  Register ) 
NVIC $F00 + constant NVIC-STIR ( Software Triggered Interrupt  Register ) 
NVIC $100 + constant NVIC-ISER0 ( Interrupt Set-Enable Register ) 
NVIC $104 + constant NVIC-ISER1 ( Interrupt Set-Enable Register ) 
NVIC $180 + constant NVIC-ICER0 ( Interrupt Clear-Enable  Register ) 
NVIC $184 + constant NVIC-ICER1 ( Interrupt Clear-Enable  Register ) 
NVIC $200 + constant NVIC-ISPR0 ( Interrupt Set-Pending Register ) 
NVIC $204 + constant NVIC-ISPR1 ( Interrupt Set-Pending Register ) 
NVIC $280 + constant NVIC-ICPR0 ( Interrupt Clear-Pending  Register ) 
NVIC $284 + constant NVIC-ICPR1 ( Interrupt Clear-Pending  Register ) 
NVIC $300 + constant NVIC-IABR0 ( Interrupt Active Bit Register ) 
NVIC $304 + constant NVIC-IABR1 ( Interrupt Active Bit Register ) 
NVIC $400 + constant NVIC-IPR0 ( Interrupt Priority Register ) 
NVIC $404 + constant NVIC-IPR1 ( Interrupt Priority Register ) 
NVIC $408 + constant NVIC-IPR2 ( Interrupt Priority Register ) 
NVIC $40C + constant NVIC-IPR3 ( Interrupt Priority Register ) 
NVIC $410 + constant NVIC-IPR4 ( Interrupt Priority Register ) 
NVIC $414 + constant NVIC-IPR5 ( Interrupt Priority Register ) 
NVIC $418 + constant NVIC-IPR6 ( Interrupt Priority Register ) 
NVIC $41C + constant NVIC-IPR7 ( Interrupt Priority Register ) 
NVIC $420 + constant NVIC-IPR8 ( Interrupt Priority Register ) 
NVIC $424 + constant NVIC-IPR9 ( Interrupt Priority Register ) 
NVIC $428 + constant NVIC-IPR10 ( Interrupt Priority Register ) 
NVIC $42C + constant NVIC-IPR11 ( Interrupt Priority Register ) 
NVIC $430 + constant NVIC-IPR12 ( Interrupt Priority Register ) 
NVIC $434 + constant NVIC-IPR13 ( Interrupt Priority Register ) 
NVIC $438 + constant NVIC-IPR14 ( Interrupt Priority Register ) 
: NVIC-ICTR. ." NVIC-ICTR (read-only) $" NVIC-ICTR @ hex. NVIC-ICTR 1b. ;
: NVIC-STIR. ." NVIC-STIR (write-only) $" NVIC-STIR @ hex. NVIC-STIR 1b. ;
: NVIC-ISER0. ." NVIC-ISER0 (read-write) $" NVIC-ISER0 @ hex. NVIC-ISER0 1b. ;
: NVIC-ISER1. ." NVIC-ISER1 (read-write) $" NVIC-ISER1 @ hex. NVIC-ISER1 1b. ;
: NVIC-ICER0. ." NVIC-ICER0 (read-write) $" NVIC-ICER0 @ hex. NVIC-ICER0 1b. ;
: NVIC-ICER1. ." NVIC-ICER1 (read-write) $" NVIC-ICER1 @ hex. NVIC-ICER1 1b. ;
: NVIC-ISPR0. ." NVIC-ISPR0 (read-write) $" NVIC-ISPR0 @ hex. NVIC-ISPR0 1b. ;
: NVIC-ISPR1. ." NVIC-ISPR1 (read-write) $" NVIC-ISPR1 @ hex. NVIC-ISPR1 1b. ;
: NVIC-ICPR0. ." NVIC-ICPR0 (read-write) $" NVIC-ICPR0 @ hex. NVIC-ICPR0 1b. ;
: NVIC-ICPR1. ." NVIC-ICPR1 (read-write) $" NVIC-ICPR1 @ hex. NVIC-ICPR1 1b. ;
: NVIC-IABR0. ." NVIC-IABR0 (read-only) $" NVIC-IABR0 @ hex. NVIC-IABR0 1b. ;
: NVIC-IABR1. ." NVIC-IABR1 (read-only) $" NVIC-IABR1 @ hex. NVIC-IABR1 1b. ;
: NVIC-IPR0. ." NVIC-IPR0 (read-write) $" NVIC-IPR0 @ hex. NVIC-IPR0 1b. ;
: NVIC-IPR1. ." NVIC-IPR1 (read-write) $" NVIC-IPR1 @ hex. NVIC-IPR1 1b. ;
: NVIC-IPR2. ." NVIC-IPR2 (read-write) $" NVIC-IPR2 @ hex. NVIC-IPR2 1b. ;
: NVIC-IPR3. ." NVIC-IPR3 (read-write) $" NVIC-IPR3 @ hex. NVIC-IPR3 1b. ;
: NVIC-IPR4. ." NVIC-IPR4 (read-write) $" NVIC-IPR4 @ hex. NVIC-IPR4 1b. ;
: NVIC-IPR5. ." NVIC-IPR5 (read-write) $" NVIC-IPR5 @ hex. NVIC-IPR5 1b. ;
: NVIC-IPR6. ." NVIC-IPR6 (read-write) $" NVIC-IPR6 @ hex. NVIC-IPR6 1b. ;
: NVIC-IPR7. ." NVIC-IPR7 (read-write) $" NVIC-IPR7 @ hex. NVIC-IPR7 1b. ;
: NVIC-IPR8. ." NVIC-IPR8 (read-write) $" NVIC-IPR8 @ hex. NVIC-IPR8 1b. ;
: NVIC-IPR9. ." NVIC-IPR9 (read-write) $" NVIC-IPR9 @ hex. NVIC-IPR9 1b. ;
: NVIC-IPR10. ." NVIC-IPR10 (read-write) $" NVIC-IPR10 @ hex. NVIC-IPR10 1b. ;
: NVIC-IPR11. ." NVIC-IPR11 (read-write) $" NVIC-IPR11 @ hex. NVIC-IPR11 1b. ;
: NVIC-IPR12. ." NVIC-IPR12 (read-write) $" NVIC-IPR12 @ hex. NVIC-IPR12 1b. ;
: NVIC-IPR13. ." NVIC-IPR13 (read-write) $" NVIC-IPR13 @ hex. NVIC-IPR13 1b. ;
: NVIC-IPR14. ." NVIC-IPR14 (read-write) $" NVIC-IPR14 @ hex. NVIC-IPR14 1b. ;
: NVIC.
NVIC-ICTR.
NVIC-STIR.
NVIC-ISER0.
NVIC-ISER1.
NVIC-ICER0.
NVIC-ICER1.
NVIC-ISPR0.
NVIC-ISPR1.
NVIC-ICPR0.
NVIC-ICPR1.
NVIC-IABR0.
NVIC-IABR1.
NVIC-IPR0.
NVIC-IPR1.
NVIC-IPR2.
NVIC-IPR3.
NVIC-IPR4.
NVIC-IPR5.
NVIC-IPR6.
NVIC-IPR7.
NVIC-IPR8.
NVIC-IPR9.
NVIC-IPR10.
NVIC-IPR11.
NVIC-IPR12.
NVIC-IPR13.
NVIC-IPR14.
;


compiletoram
