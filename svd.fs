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

$40020400 constant DMA2 ( DMA controller ) 
DMA2 $0 + constant DMA2-ISR ( DMA interrupt status register  DMA_ISR ) 
DMA2 $4 + constant DMA2-IFCR ( DMA interrupt flag clear register  DMA_IFCR ) 
DMA2 $8 + constant DMA2-CCR1 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $C + constant DMA2-CNDTR1 ( DMA channel 1 number of data  register ) 
DMA2 $10 + constant DMA2-CPAR1 ( DMA channel 1 peripheral address  register ) 
DMA2 $14 + constant DMA2-CMAR1 ( DMA channel 1 memory address  register ) 
DMA2 $1C + constant DMA2-CCR2 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $20 + constant DMA2-CNDTR2 ( DMA channel 2 number of data  register ) 
DMA2 $24 + constant DMA2-CPAR2 ( DMA channel 2 peripheral address  register ) 
DMA2 $28 + constant DMA2-CMAR2 ( DMA channel 2 memory address  register ) 
DMA2 $30 + constant DMA2-CCR3 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $34 + constant DMA2-CNDTR3 ( DMA channel 3 number of data  register ) 
DMA2 $38 + constant DMA2-CPAR3 ( DMA channel 3 peripheral address  register ) 
DMA2 $3C + constant DMA2-CMAR3 ( DMA channel 3 memory address  register ) 
DMA2 $44 + constant DMA2-CCR4 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $48 + constant DMA2-CNDTR4 ( DMA channel 4 number of data  register ) 
DMA2 $4C + constant DMA2-CPAR4 ( DMA channel 4 peripheral address  register ) 
DMA2 $50 + constant DMA2-CMAR4 ( DMA channel 4 memory address  register ) 
DMA2 $58 + constant DMA2-CCR5 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $5C + constant DMA2-CNDTR5 ( DMA channel 5 number of data  register ) 
DMA2 $60 + constant DMA2-CPAR5 ( DMA channel 5 peripheral address  register ) 
DMA2 $64 + constant DMA2-CMAR5 ( DMA channel 5 memory address  register ) 
DMA2 $6C + constant DMA2-CCR6 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $70 + constant DMA2-CNDTR6 ( DMA channel 6 number of data  register ) 
DMA2 $74 + constant DMA2-CPAR6 ( DMA channel 6 peripheral address  register ) 
DMA2 $78 + constant DMA2-CMAR6 ( DMA channel 6 memory address  register ) 
DMA2 $80 + constant DMA2-CCR7 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $84 + constant DMA2-CNDTR7 ( DMA channel 7 number of data  register ) 
DMA2 $88 + constant DMA2-CPAR7 ( DMA channel 7 peripheral address  register ) 
DMA2 $8C + constant DMA2-CMAR7 ( DMA channel 7 memory address  register ) 
: DMA2-ISR. ." DMA2-ISR (read-only) $" DMA2-ISR @ hex. DMA2-ISR 1b. ;
: DMA2-IFCR. ." DMA2-IFCR (write-only) $" DMA2-IFCR @ hex. DMA2-IFCR 1b. ;
: DMA2-CCR1. ." DMA2-CCR1 (read-write) $" DMA2-CCR1 @ hex. DMA2-CCR1 1b. ;
: DMA2-CNDTR1. ." DMA2-CNDTR1 (read-write) $" DMA2-CNDTR1 @ hex. DMA2-CNDTR1 1b. ;
: DMA2-CPAR1. ." DMA2-CPAR1 (read-write) $" DMA2-CPAR1 @ hex. DMA2-CPAR1 1b. ;
: DMA2-CMAR1. ." DMA2-CMAR1 (read-write) $" DMA2-CMAR1 @ hex. DMA2-CMAR1 1b. ;
: DMA2-CCR2. ." DMA2-CCR2 (read-write) $" DMA2-CCR2 @ hex. DMA2-CCR2 1b. ;
: DMA2-CNDTR2. ." DMA2-CNDTR2 (read-write) $" DMA2-CNDTR2 @ hex. DMA2-CNDTR2 1b. ;
: DMA2-CPAR2. ." DMA2-CPAR2 (read-write) $" DMA2-CPAR2 @ hex. DMA2-CPAR2 1b. ;
: DMA2-CMAR2. ." DMA2-CMAR2 (read-write) $" DMA2-CMAR2 @ hex. DMA2-CMAR2 1b. ;
: DMA2-CCR3. ." DMA2-CCR3 (read-write) $" DMA2-CCR3 @ hex. DMA2-CCR3 1b. ;
: DMA2-CNDTR3. ." DMA2-CNDTR3 (read-write) $" DMA2-CNDTR3 @ hex. DMA2-CNDTR3 1b. ;
: DMA2-CPAR3. ." DMA2-CPAR3 (read-write) $" DMA2-CPAR3 @ hex. DMA2-CPAR3 1b. ;
: DMA2-CMAR3. ." DMA2-CMAR3 (read-write) $" DMA2-CMAR3 @ hex. DMA2-CMAR3 1b. ;
: DMA2-CCR4. ." DMA2-CCR4 (read-write) $" DMA2-CCR4 @ hex. DMA2-CCR4 1b. ;
: DMA2-CNDTR4. ." DMA2-CNDTR4 (read-write) $" DMA2-CNDTR4 @ hex. DMA2-CNDTR4 1b. ;
: DMA2-CPAR4. ." DMA2-CPAR4 (read-write) $" DMA2-CPAR4 @ hex. DMA2-CPAR4 1b. ;
: DMA2-CMAR4. ." DMA2-CMAR4 (read-write) $" DMA2-CMAR4 @ hex. DMA2-CMAR4 1b. ;
: DMA2-CCR5. ." DMA2-CCR5 (read-write) $" DMA2-CCR5 @ hex. DMA2-CCR5 1b. ;
: DMA2-CNDTR5. ." DMA2-CNDTR5 (read-write) $" DMA2-CNDTR5 @ hex. DMA2-CNDTR5 1b. ;
: DMA2-CPAR5. ." DMA2-CPAR5 (read-write) $" DMA2-CPAR5 @ hex. DMA2-CPAR5 1b. ;
: DMA2-CMAR5. ." DMA2-CMAR5 (read-write) $" DMA2-CMAR5 @ hex. DMA2-CMAR5 1b. ;
: DMA2-CCR6. ." DMA2-CCR6 (read-write) $" DMA2-CCR6 @ hex. DMA2-CCR6 1b. ;
: DMA2-CNDTR6. ." DMA2-CNDTR6 (read-write) $" DMA2-CNDTR6 @ hex. DMA2-CNDTR6 1b. ;
: DMA2-CPAR6. ." DMA2-CPAR6 (read-write) $" DMA2-CPAR6 @ hex. DMA2-CPAR6 1b. ;
: DMA2-CMAR6. ." DMA2-CMAR6 (read-write) $" DMA2-CMAR6 @ hex. DMA2-CMAR6 1b. ;
: DMA2-CCR7. ." DMA2-CCR7 (read-write) $" DMA2-CCR7 @ hex. DMA2-CCR7 1b. ;
: DMA2-CNDTR7. ." DMA2-CNDTR7 (read-write) $" DMA2-CNDTR7 @ hex. DMA2-CNDTR7 1b. ;
: DMA2-CPAR7. ." DMA2-CPAR7 (read-write) $" DMA2-CPAR7 @ hex. DMA2-CPAR7 1b. ;
: DMA2-CMAR7. ." DMA2-CMAR7 (read-write) $" DMA2-CMAR7 @ hex. DMA2-CMAR7 1b. ;
: DMA2.
DMA2-ISR.
DMA2-IFCR.
DMA2-CCR1.
DMA2-CNDTR1.
DMA2-CPAR1.
DMA2-CMAR1.
DMA2-CCR2.
DMA2-CNDTR2.
DMA2-CPAR2.
DMA2-CMAR2.
DMA2-CCR3.
DMA2-CNDTR3.
DMA2-CPAR3.
DMA2-CMAR3.
DMA2-CCR4.
DMA2-CNDTR4.
DMA2-CPAR4.
DMA2-CMAR4.
DMA2-CCR5.
DMA2-CNDTR5.
DMA2-CPAR5.
DMA2-CMAR5.
DMA2-CCR6.
DMA2-CNDTR6.
DMA2-CPAR6.
DMA2-CMAR6.
DMA2-CCR7.
DMA2-CNDTR7.
DMA2-CPAR7.
DMA2-CMAR7.
;

$40002800 constant RTC ( Real time clock ) 
RTC $0 + constant RTC-CRH ( RTC Control Register High ) 
RTC $4 + constant RTC-CRL ( RTC Control Register Low ) 
RTC $8 + constant RTC-PRLH ( RTC Prescaler Load Register  High ) 
RTC $C + constant RTC-PRLL ( RTC Prescaler Load Register  Low ) 
RTC $10 + constant RTC-DIVH ( RTC Prescaler Divider Register  High ) 
RTC $14 + constant RTC-DIVL ( RTC Prescaler Divider Register  Low ) 
RTC $18 + constant RTC-CNTH ( RTC Counter Register High ) 
RTC $1C + constant RTC-CNTL ( RTC Counter Register Low ) 
RTC $20 + constant RTC-ALRH ( RTC Alarm Register High ) 
RTC $24 + constant RTC-ALRL ( RTC Alarm Register Low ) 
: RTC-CRH. ." RTC-CRH (read-write) $" RTC-CRH @ hex. RTC-CRH 1b. ;
: RTC-CRL. ." RTC-CRL () $" RTC-CRL @ hex. RTC-CRL 1b. ;
: RTC-PRLH. ." RTC-PRLH (write-only) $" RTC-PRLH @ hex. RTC-PRLH 1b. ;
: RTC-PRLL. ." RTC-PRLL (write-only) $" RTC-PRLL @ hex. RTC-PRLL 1b. ;
: RTC-DIVH. ." RTC-DIVH (read-only) $" RTC-DIVH @ hex. RTC-DIVH 1b. ;
: RTC-DIVL. ." RTC-DIVL (read-only) $" RTC-DIVL @ hex. RTC-DIVL 1b. ;
: RTC-CNTH. ." RTC-CNTH (read-write) $" RTC-CNTH @ hex. RTC-CNTH 1b. ;
: RTC-CNTL. ." RTC-CNTL (read-write) $" RTC-CNTL @ hex. RTC-CNTL 1b. ;
: RTC-ALRH. ." RTC-ALRH (write-only) $" RTC-ALRH @ hex. RTC-ALRH 1b. ;
: RTC-ALRL. ." RTC-ALRL (write-only) $" RTC-ALRL @ hex. RTC-ALRL 1b. ;
: RTC.
RTC-CRH.
RTC-CRL.
RTC-PRLH.
RTC-PRLL.
RTC-DIVH.
RTC-DIVL.
RTC-CNTH.
RTC-CNTL.
RTC-ALRH.
RTC-ALRL.
;

$40006C04 constant BKP ( Backup registers ) 
BKP $0 + constant BKP-DR1 ( Backup data register BKP_DR ) 
BKP $4 + constant BKP-DR2 ( Backup data register BKP_DR ) 
BKP $8 + constant BKP-DR3 ( Backup data register BKP_DR ) 
BKP $C + constant BKP-DR4 ( Backup data register BKP_DR ) 
BKP $10 + constant BKP-DR5 ( Backup data register BKP_DR ) 
BKP $14 + constant BKP-DR6 ( Backup data register BKP_DR ) 
BKP $18 + constant BKP-DR7 ( Backup data register BKP_DR ) 
BKP $1C + constant BKP-DR8 ( Backup data register BKP_DR ) 
BKP $20 + constant BKP-DR9 ( Backup data register BKP_DR ) 
BKP $24 + constant BKP-DR10 ( Backup data register BKP_DR ) 
BKP $3C + constant BKP-DR11 ( Backup data register BKP_DR ) 
BKP $40 + constant BKP-DR12 ( Backup data register BKP_DR ) 
BKP $44 + constant BKP-DR13 ( Backup data register BKP_DR ) 
BKP $48 + constant BKP-DR14 ( Backup data register BKP_DR ) 
BKP $4C + constant BKP-DR15 ( Backup data register BKP_DR ) 
BKP $50 + constant BKP-DR16 ( Backup data register BKP_DR ) 
BKP $54 + constant BKP-DR17 ( Backup data register BKP_DR ) 
BKP $58 + constant BKP-DR18 ( Backup data register BKP_DR ) 
BKP $5C + constant BKP-DR19 ( Backup data register BKP_DR ) 
BKP $60 + constant BKP-DR20 ( Backup data register BKP_DR ) 
BKP $64 + constant BKP-DR21 ( Backup data register BKP_DR ) 
BKP $68 + constant BKP-DR22 ( Backup data register BKP_DR ) 
BKP $6C + constant BKP-DR23 ( Backup data register BKP_DR ) 
BKP $70 + constant BKP-DR24 ( Backup data register BKP_DR ) 
BKP $74 + constant BKP-DR25 ( Backup data register BKP_DR ) 
BKP $78 + constant BKP-DR26 ( Backup data register BKP_DR ) 
BKP $7C + constant BKP-DR27 ( Backup data register BKP_DR ) 
BKP $80 + constant BKP-DR28 ( Backup data register BKP_DR ) 
BKP $84 + constant BKP-DR29 ( Backup data register BKP_DR ) 
BKP $88 + constant BKP-DR30 ( Backup data register BKP_DR ) 
BKP $8C + constant BKP-DR31 ( Backup data register BKP_DR ) 
BKP $90 + constant BKP-DR32 ( Backup data register BKP_DR ) 
BKP $94 + constant BKP-DR33 ( Backup data register BKP_DR ) 
BKP $98 + constant BKP-DR34 ( Backup data register BKP_DR ) 
BKP $9C + constant BKP-DR35 ( Backup data register BKP_DR ) 
BKP $A0 + constant BKP-DR36 ( Backup data register BKP_DR ) 
BKP $A4 + constant BKP-DR37 ( Backup data register BKP_DR ) 
BKP $A8 + constant BKP-DR38 ( Backup data register BKP_DR ) 
BKP $AC + constant BKP-DR39 ( Backup data register BKP_DR ) 
BKP $B0 + constant BKP-DR40 ( Backup data register BKP_DR ) 
BKP $B4 + constant BKP-DR41 ( Backup data register BKP_DR ) 
BKP $B8 + constant BKP-DR42 ( Backup data register BKP_DR ) 
BKP $28 + constant BKP-RTCCR ( RTC clock calibration register  BKP_RTCCR ) 
BKP $2C + constant BKP-CR ( Backup control register  BKP_CR ) 
BKP $30 + constant BKP-CSR ( BKP_CSR control/status register  BKP_CSR ) 
: BKP-DR1. ." BKP-DR1 (read-write) $" BKP-DR1 @ hex. BKP-DR1 1b. ;
: BKP-DR2. ." BKP-DR2 (read-write) $" BKP-DR2 @ hex. BKP-DR2 1b. ;
: BKP-DR3. ." BKP-DR3 (read-write) $" BKP-DR3 @ hex. BKP-DR3 1b. ;
: BKP-DR4. ." BKP-DR4 (read-write) $" BKP-DR4 @ hex. BKP-DR4 1b. ;
: BKP-DR5. ." BKP-DR5 (read-write) $" BKP-DR5 @ hex. BKP-DR5 1b. ;
: BKP-DR6. ." BKP-DR6 (read-write) $" BKP-DR6 @ hex. BKP-DR6 1b. ;
: BKP-DR7. ." BKP-DR7 (read-write) $" BKP-DR7 @ hex. BKP-DR7 1b. ;
: BKP-DR8. ." BKP-DR8 (read-write) $" BKP-DR8 @ hex. BKP-DR8 1b. ;
: BKP-DR9. ." BKP-DR9 (read-write) $" BKP-DR9 @ hex. BKP-DR9 1b. ;
: BKP-DR10. ." BKP-DR10 (read-write) $" BKP-DR10 @ hex. BKP-DR10 1b. ;
: BKP-DR11. ." BKP-DR11 (read-write) $" BKP-DR11 @ hex. BKP-DR11 1b. ;
: BKP-DR12. ." BKP-DR12 (read-write) $" BKP-DR12 @ hex. BKP-DR12 1b. ;
: BKP-DR13. ." BKP-DR13 (read-write) $" BKP-DR13 @ hex. BKP-DR13 1b. ;
: BKP-DR14. ." BKP-DR14 (read-write) $" BKP-DR14 @ hex. BKP-DR14 1b. ;
: BKP-DR15. ." BKP-DR15 (read-write) $" BKP-DR15 @ hex. BKP-DR15 1b. ;
: BKP-DR16. ." BKP-DR16 (read-write) $" BKP-DR16 @ hex. BKP-DR16 1b. ;
: BKP-DR17. ." BKP-DR17 (read-write) $" BKP-DR17 @ hex. BKP-DR17 1b. ;
: BKP-DR18. ." BKP-DR18 (read-write) $" BKP-DR18 @ hex. BKP-DR18 1b. ;
: BKP-DR19. ." BKP-DR19 (read-write) $" BKP-DR19 @ hex. BKP-DR19 1b. ;
: BKP-DR20. ." BKP-DR20 (read-write) $" BKP-DR20 @ hex. BKP-DR20 1b. ;
: BKP-DR21. ." BKP-DR21 (read-write) $" BKP-DR21 @ hex. BKP-DR21 1b. ;
: BKP-DR22. ." BKP-DR22 (read-write) $" BKP-DR22 @ hex. BKP-DR22 1b. ;
: BKP-DR23. ." BKP-DR23 (read-write) $" BKP-DR23 @ hex. BKP-DR23 1b. ;
: BKP-DR24. ." BKP-DR24 (read-write) $" BKP-DR24 @ hex. BKP-DR24 1b. ;
: BKP-DR25. ." BKP-DR25 (read-write) $" BKP-DR25 @ hex. BKP-DR25 1b. ;
: BKP-DR26. ." BKP-DR26 (read-write) $" BKP-DR26 @ hex. BKP-DR26 1b. ;
: BKP-DR27. ." BKP-DR27 (read-write) $" BKP-DR27 @ hex. BKP-DR27 1b. ;
: BKP-DR28. ." BKP-DR28 (read-write) $" BKP-DR28 @ hex. BKP-DR28 1b. ;
: BKP-DR29. ." BKP-DR29 (read-write) $" BKP-DR29 @ hex. BKP-DR29 1b. ;
: BKP-DR30. ." BKP-DR30 (read-write) $" BKP-DR30 @ hex. BKP-DR30 1b. ;
: BKP-DR31. ." BKP-DR31 (read-write) $" BKP-DR31 @ hex. BKP-DR31 1b. ;
: BKP-DR32. ." BKP-DR32 (read-write) $" BKP-DR32 @ hex. BKP-DR32 1b. ;
: BKP-DR33. ." BKP-DR33 (read-write) $" BKP-DR33 @ hex. BKP-DR33 1b. ;
: BKP-DR34. ." BKP-DR34 (read-write) $" BKP-DR34 @ hex. BKP-DR34 1b. ;
: BKP-DR35. ." BKP-DR35 (read-write) $" BKP-DR35 @ hex. BKP-DR35 1b. ;
: BKP-DR36. ." BKP-DR36 (read-write) $" BKP-DR36 @ hex. BKP-DR36 1b. ;
: BKP-DR37. ." BKP-DR37 (read-write) $" BKP-DR37 @ hex. BKP-DR37 1b. ;
: BKP-DR38. ." BKP-DR38 (read-write) $" BKP-DR38 @ hex. BKP-DR38 1b. ;
: BKP-DR39. ." BKP-DR39 (read-write) $" BKP-DR39 @ hex. BKP-DR39 1b. ;
: BKP-DR40. ." BKP-DR40 (read-write) $" BKP-DR40 @ hex. BKP-DR40 1b. ;
: BKP-DR41. ." BKP-DR41 (read-write) $" BKP-DR41 @ hex. BKP-DR41 1b. ;
: BKP-DR42. ." BKP-DR42 (read-write) $" BKP-DR42 @ hex. BKP-DR42 1b. ;
: BKP-RTCCR. ." BKP-RTCCR (read-write) $" BKP-RTCCR @ hex. BKP-RTCCR 1b. ;
: BKP-CR. ." BKP-CR (read-write) $" BKP-CR @ hex. BKP-CR 1b. ;
: BKP-CSR. ." BKP-CSR () $" BKP-CSR @ hex. BKP-CSR 1b. ;
: BKP.
BKP-DR1.
BKP-DR2.
BKP-DR3.
BKP-DR4.
BKP-DR5.
BKP-DR6.
BKP-DR7.
BKP-DR8.
BKP-DR9.
BKP-DR10.
BKP-DR11.
BKP-DR12.
BKP-DR13.
BKP-DR14.
BKP-DR15.
BKP-DR16.
BKP-DR17.
BKP-DR18.
BKP-DR19.
BKP-DR20.
BKP-DR21.
BKP-DR22.
BKP-DR23.
BKP-DR24.
BKP-DR25.
BKP-DR26.
BKP-DR27.
BKP-DR28.
BKP-DR29.
BKP-DR30.
BKP-DR31.
BKP-DR32.
BKP-DR33.
BKP-DR34.
BKP-DR35.
BKP-DR36.
BKP-DR37.
BKP-DR38.
BKP-DR39.
BKP-DR40.
BKP-DR41.
BKP-DR42.
BKP-RTCCR.
BKP-CR.
BKP-CSR.
;

$40003000 constant IWDG ( Independent watchdog ) 
IWDG $0 + constant IWDG-KR ( Key register IWDG_KR ) 
IWDG $4 + constant IWDG-PR ( Prescaler register IWDG_PR ) 
IWDG $8 + constant IWDG-RLR ( Reload register IWDG_RLR ) 
IWDG $C + constant IWDG-SR ( Status register IWDG_SR ) 
: IWDG-KR. ." IWDG-KR (write-only) $" IWDG-KR @ hex. IWDG-KR 1b. ;
: IWDG-PR. ." IWDG-PR (read-write) $" IWDG-PR @ hex. IWDG-PR 1b. ;
: IWDG-RLR. ." IWDG-RLR (read-write) $" IWDG-RLR @ hex. IWDG-RLR 1b. ;
: IWDG-SR. ." IWDG-SR (read-only) $" IWDG-SR @ hex. IWDG-SR 1b. ;
: IWDG.
IWDG-KR.
IWDG-PR.
IWDG-RLR.
IWDG-SR.
;

$40002C00 constant WWDG ( Window watchdog ) 
WWDG $0 + constant WWDG-CR ( Control register WWDG_CR ) 
WWDG $4 + constant WWDG-CFR ( Configuration register  WWDG_CFR ) 
WWDG $8 + constant WWDG-SR ( Status register WWDG_SR ) 
: WWDG-CR. ." WWDG-CR (read-write) $" WWDG-CR @ hex. WWDG-CR 1b. ;
: WWDG-CFR. ." WWDG-CFR (read-write) $" WWDG-CFR @ hex. WWDG-CFR 1b. ;
: WWDG-SR. ." WWDG-SR (read-write) $" WWDG-SR @ hex. WWDG-SR 1b. ;
: WWDG.
WWDG-CR.
WWDG-CFR.
WWDG-SR.
;

$40012C00 constant TIM1 ( Advanced timer ) 
TIM1 $0 + constant TIM1-CR1 ( control register 1 ) 
TIM1 $4 + constant TIM1-CR2 ( control register 2 ) 
TIM1 $8 + constant TIM1-SMCR ( slave mode control register ) 
TIM1 $C + constant TIM1-DIER ( DMA/Interrupt enable register ) 
TIM1 $10 + constant TIM1-SR ( status register ) 
TIM1 $14 + constant TIM1-EGR ( event generation register ) 
TIM1 $18 + constant TIM1-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM1 $18 + constant TIM1-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM1 $1C + constant TIM1-CCMR2_Output ( capture/compare mode register output  mode ) 
TIM1 $1C + constant TIM1-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM1 $20 + constant TIM1-CCER ( capture/compare enable  register ) 
TIM1 $24 + constant TIM1-CNT ( counter ) 
TIM1 $28 + constant TIM1-PSC ( prescaler ) 
TIM1 $2C + constant TIM1-ARR ( auto-reload register ) 
TIM1 $34 + constant TIM1-CCR1 ( capture/compare register 1 ) 
TIM1 $38 + constant TIM1-CCR2 ( capture/compare register 2 ) 
TIM1 $3C + constant TIM1-CCR3 ( capture/compare register 3 ) 
TIM1 $40 + constant TIM1-CCR4 ( capture/compare register 4 ) 
TIM1 $48 + constant TIM1-DCR ( DMA control register ) 
TIM1 $4C + constant TIM1-DMAR ( DMA address for full transfer ) 
TIM1 $30 + constant TIM1-RCR ( repetition counter register ) 
TIM1 $44 + constant TIM1-BDTR ( break and dead-time register ) 
: TIM1-CR1. ." TIM1-CR1 (read-write) $" TIM1-CR1 @ hex. TIM1-CR1 1b. ;
: TIM1-CR2. ." TIM1-CR2 (read-write) $" TIM1-CR2 @ hex. TIM1-CR2 1b. ;
: TIM1-SMCR. ." TIM1-SMCR (read-write) $" TIM1-SMCR @ hex. TIM1-SMCR 1b. ;
: TIM1-DIER. ." TIM1-DIER (read-write) $" TIM1-DIER @ hex. TIM1-DIER 1b. ;
: TIM1-SR. ." TIM1-SR (read-write) $" TIM1-SR @ hex. TIM1-SR 1b. ;
: TIM1-EGR. ." TIM1-EGR (write-only) $" TIM1-EGR @ hex. TIM1-EGR 1b. ;
: TIM1-CCMR1_Output. ." TIM1-CCMR1_Output (read-write) $" TIM1-CCMR1_Output @ hex. TIM1-CCMR1_Output 1b. ;
: TIM1-CCMR1_Input. ." TIM1-CCMR1_Input (read-write) $" TIM1-CCMR1_Input @ hex. TIM1-CCMR1_Input 1b. ;
: TIM1-CCMR2_Output. ." TIM1-CCMR2_Output (read-write) $" TIM1-CCMR2_Output @ hex. TIM1-CCMR2_Output 1b. ;
: TIM1-CCMR2_Input. ." TIM1-CCMR2_Input (read-write) $" TIM1-CCMR2_Input @ hex. TIM1-CCMR2_Input 1b. ;
: TIM1-CCER. ." TIM1-CCER (read-write) $" TIM1-CCER @ hex. TIM1-CCER 1b. ;
: TIM1-CNT. ." TIM1-CNT (read-write) $" TIM1-CNT @ hex. TIM1-CNT 1b. ;
: TIM1-PSC. ." TIM1-PSC (read-write) $" TIM1-PSC @ hex. TIM1-PSC 1b. ;
: TIM1-ARR. ." TIM1-ARR (read-write) $" TIM1-ARR @ hex. TIM1-ARR 1b. ;
: TIM1-CCR1. ." TIM1-CCR1 (read-write) $" TIM1-CCR1 @ hex. TIM1-CCR1 1b. ;
: TIM1-CCR2. ." TIM1-CCR2 (read-write) $" TIM1-CCR2 @ hex. TIM1-CCR2 1b. ;
: TIM1-CCR3. ." TIM1-CCR3 (read-write) $" TIM1-CCR3 @ hex. TIM1-CCR3 1b. ;
: TIM1-CCR4. ." TIM1-CCR4 (read-write) $" TIM1-CCR4 @ hex. TIM1-CCR4 1b. ;
: TIM1-DCR. ." TIM1-DCR (read-write) $" TIM1-DCR @ hex. TIM1-DCR 1b. ;
: TIM1-DMAR. ." TIM1-DMAR (read-write) $" TIM1-DMAR @ hex. TIM1-DMAR 1b. ;
: TIM1-RCR. ." TIM1-RCR (read-write) $" TIM1-RCR @ hex. TIM1-RCR 1b. ;
: TIM1-BDTR. ." TIM1-BDTR (read-write) $" TIM1-BDTR @ hex. TIM1-BDTR 1b. ;
: TIM1.
TIM1-CR1.
TIM1-CR2.
TIM1-SMCR.
TIM1-DIER.
TIM1-SR.
TIM1-EGR.
TIM1-CCMR1_Output.
TIM1-CCMR1_Input.
TIM1-CCMR2_Output.
TIM1-CCMR2_Input.
TIM1-CCER.
TIM1-CNT.
TIM1-PSC.
TIM1-ARR.
TIM1-CCR1.
TIM1-CCR2.
TIM1-CCR3.
TIM1-CCR4.
TIM1-DCR.
TIM1-DMAR.
TIM1-RCR.
TIM1-BDTR.
;

$40000000 constant TIM2 ( General purpose timer ) 
TIM2 $0 + constant TIM2-CR1 ( control register 1 ) 
TIM2 $4 + constant TIM2-CR2 ( control register 2 ) 
TIM2 $8 + constant TIM2-SMCR ( slave mode control register ) 
TIM2 $C + constant TIM2-DIER ( DMA/Interrupt enable register ) 
TIM2 $10 + constant TIM2-SR ( status register ) 
TIM2 $14 + constant TIM2-EGR ( event generation register ) 
TIM2 $18 + constant TIM2-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM2 $18 + constant TIM2-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM2 $1C + constant TIM2-CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM2 $1C + constant TIM2-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM2 $20 + constant TIM2-CCER ( capture/compare enable  register ) 
TIM2 $24 + constant TIM2-CNT ( counter ) 
TIM2 $28 + constant TIM2-PSC ( prescaler ) 
TIM2 $2C + constant TIM2-ARR ( auto-reload register ) 
TIM2 $34 + constant TIM2-CCR1 ( capture/compare register 1 ) 
TIM2 $38 + constant TIM2-CCR2 ( capture/compare register 2 ) 
TIM2 $3C + constant TIM2-CCR3 ( capture/compare register 3 ) 
TIM2 $40 + constant TIM2-CCR4 ( capture/compare register 4 ) 
TIM2 $48 + constant TIM2-DCR ( DMA control register ) 
TIM2 $4C + constant TIM2-DMAR ( DMA address for full transfer ) 
: TIM2-CR1. ." TIM2-CR1 (read-write) $" TIM2-CR1 @ hex. TIM2-CR1 1b. ;
: TIM2-CR2. ." TIM2-CR2 (read-write) $" TIM2-CR2 @ hex. TIM2-CR2 1b. ;
: TIM2-SMCR. ." TIM2-SMCR (read-write) $" TIM2-SMCR @ hex. TIM2-SMCR 1b. ;
: TIM2-DIER. ." TIM2-DIER (read-write) $" TIM2-DIER @ hex. TIM2-DIER 1b. ;
: TIM2-SR. ." TIM2-SR (read-write) $" TIM2-SR @ hex. TIM2-SR 1b. ;
: TIM2-EGR. ." TIM2-EGR (write-only) $" TIM2-EGR @ hex. TIM2-EGR 1b. ;
: TIM2-CCMR1_Output. ." TIM2-CCMR1_Output (read-write) $" TIM2-CCMR1_Output @ hex. TIM2-CCMR1_Output 1b. ;
: TIM2-CCMR1_Input. ." TIM2-CCMR1_Input (read-write) $" TIM2-CCMR1_Input @ hex. TIM2-CCMR1_Input 1b. ;
: TIM2-CCMR2_Output. ." TIM2-CCMR2_Output (read-write) $" TIM2-CCMR2_Output @ hex. TIM2-CCMR2_Output 1b. ;
: TIM2-CCMR2_Input. ." TIM2-CCMR2_Input (read-write) $" TIM2-CCMR2_Input @ hex. TIM2-CCMR2_Input 1b. ;
: TIM2-CCER. ." TIM2-CCER (read-write) $" TIM2-CCER @ hex. TIM2-CCER 1b. ;
: TIM2-CNT. ." TIM2-CNT (read-write) $" TIM2-CNT @ hex. TIM2-CNT 1b. ;
: TIM2-PSC. ." TIM2-PSC (read-write) $" TIM2-PSC @ hex. TIM2-PSC 1b. ;
: TIM2-ARR. ." TIM2-ARR (read-write) $" TIM2-ARR @ hex. TIM2-ARR 1b. ;
: TIM2-CCR1. ." TIM2-CCR1 (read-write) $" TIM2-CCR1 @ hex. TIM2-CCR1 1b. ;
: TIM2-CCR2. ." TIM2-CCR2 (read-write) $" TIM2-CCR2 @ hex. TIM2-CCR2 1b. ;
: TIM2-CCR3. ." TIM2-CCR3 (read-write) $" TIM2-CCR3 @ hex. TIM2-CCR3 1b. ;
: TIM2-CCR4. ." TIM2-CCR4 (read-write) $" TIM2-CCR4 @ hex. TIM2-CCR4 1b. ;
: TIM2-DCR. ." TIM2-DCR (read-write) $" TIM2-DCR @ hex. TIM2-DCR 1b. ;
: TIM2-DMAR. ." TIM2-DMAR (read-write) $" TIM2-DMAR @ hex. TIM2-DMAR 1b. ;
: TIM2.
TIM2-CR1.
TIM2-CR2.
TIM2-SMCR.
TIM2-DIER.
TIM2-SR.
TIM2-EGR.
TIM2-CCMR1_Output.
TIM2-CCMR1_Input.
TIM2-CCMR2_Output.
TIM2-CCMR2_Input.
TIM2-CCER.
TIM2-CNT.
TIM2-PSC.
TIM2-ARR.
TIM2-CCR1.
TIM2-CCR2.
TIM2-CCR3.
TIM2-CCR4.
TIM2-DCR.
TIM2-DMAR.
;

$40000400 constant TIM3 ( General purpose timer ) 
TIM3 $0 + constant TIM3-CR1 ( control register 1 ) 
TIM3 $4 + constant TIM3-CR2 ( control register 2 ) 
TIM3 $8 + constant TIM3-SMCR ( slave mode control register ) 
TIM3 $C + constant TIM3-DIER ( DMA/Interrupt enable register ) 
TIM3 $10 + constant TIM3-SR ( status register ) 
TIM3 $14 + constant TIM3-EGR ( event generation register ) 
TIM3 $18 + constant TIM3-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM3 $18 + constant TIM3-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM3 $1C + constant TIM3-CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM3 $1C + constant TIM3-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM3 $20 + constant TIM3-CCER ( capture/compare enable  register ) 
TIM3 $24 + constant TIM3-CNT ( counter ) 
TIM3 $28 + constant TIM3-PSC ( prescaler ) 
TIM3 $2C + constant TIM3-ARR ( auto-reload register ) 
TIM3 $34 + constant TIM3-CCR1 ( capture/compare register 1 ) 
TIM3 $38 + constant TIM3-CCR2 ( capture/compare register 2 ) 
TIM3 $3C + constant TIM3-CCR3 ( capture/compare register 3 ) 
TIM3 $40 + constant TIM3-CCR4 ( capture/compare register 4 ) 
TIM3 $48 + constant TIM3-DCR ( DMA control register ) 
TIM3 $4C + constant TIM3-DMAR ( DMA address for full transfer ) 
: TIM3-CR1. ." TIM3-CR1 (read-write) $" TIM3-CR1 @ hex. TIM3-CR1 1b. ;
: TIM3-CR2. ." TIM3-CR2 (read-write) $" TIM3-CR2 @ hex. TIM3-CR2 1b. ;
: TIM3-SMCR. ." TIM3-SMCR (read-write) $" TIM3-SMCR @ hex. TIM3-SMCR 1b. ;
: TIM3-DIER. ." TIM3-DIER (read-write) $" TIM3-DIER @ hex. TIM3-DIER 1b. ;
: TIM3-SR. ." TIM3-SR (read-write) $" TIM3-SR @ hex. TIM3-SR 1b. ;
: TIM3-EGR. ." TIM3-EGR (write-only) $" TIM3-EGR @ hex. TIM3-EGR 1b. ;
: TIM3-CCMR1_Output. ." TIM3-CCMR1_Output (read-write) $" TIM3-CCMR1_Output @ hex. TIM3-CCMR1_Output 1b. ;
: TIM3-CCMR1_Input. ." TIM3-CCMR1_Input (read-write) $" TIM3-CCMR1_Input @ hex. TIM3-CCMR1_Input 1b. ;
: TIM3-CCMR2_Output. ." TIM3-CCMR2_Output (read-write) $" TIM3-CCMR2_Output @ hex. TIM3-CCMR2_Output 1b. ;
: TIM3-CCMR2_Input. ." TIM3-CCMR2_Input (read-write) $" TIM3-CCMR2_Input @ hex. TIM3-CCMR2_Input 1b. ;
: TIM3-CCER. ." TIM3-CCER (read-write) $" TIM3-CCER @ hex. TIM3-CCER 1b. ;
: TIM3-CNT. ." TIM3-CNT (read-write) $" TIM3-CNT @ hex. TIM3-CNT 1b. ;
: TIM3-PSC. ." TIM3-PSC (read-write) $" TIM3-PSC @ hex. TIM3-PSC 1b. ;
: TIM3-ARR. ." TIM3-ARR (read-write) $" TIM3-ARR @ hex. TIM3-ARR 1b. ;
: TIM3-CCR1. ." TIM3-CCR1 (read-write) $" TIM3-CCR1 @ hex. TIM3-CCR1 1b. ;
: TIM3-CCR2. ." TIM3-CCR2 (read-write) $" TIM3-CCR2 @ hex. TIM3-CCR2 1b. ;
: TIM3-CCR3. ." TIM3-CCR3 (read-write) $" TIM3-CCR3 @ hex. TIM3-CCR3 1b. ;
: TIM3-CCR4. ." TIM3-CCR4 (read-write) $" TIM3-CCR4 @ hex. TIM3-CCR4 1b. ;
: TIM3-DCR. ." TIM3-DCR (read-write) $" TIM3-DCR @ hex. TIM3-DCR 1b. ;
: TIM3-DMAR. ." TIM3-DMAR (read-write) $" TIM3-DMAR @ hex. TIM3-DMAR 1b. ;
: TIM3.
TIM3-CR1.
TIM3-CR2.
TIM3-SMCR.
TIM3-DIER.
TIM3-SR.
TIM3-EGR.
TIM3-CCMR1_Output.
TIM3-CCMR1_Input.
TIM3-CCMR2_Output.
TIM3-CCMR2_Input.
TIM3-CCER.
TIM3-CNT.
TIM3-PSC.
TIM3-ARR.
TIM3-CCR1.
TIM3-CCR2.
TIM3-CCR3.
TIM3-CCR4.
TIM3-DCR.
TIM3-DMAR.
;

$40000800 constant TIM4 ( General purpose timer ) 
TIM4 $0 + constant TIM4-CR1 ( control register 1 ) 
TIM4 $4 + constant TIM4-CR2 ( control register 2 ) 
TIM4 $8 + constant TIM4-SMCR ( slave mode control register ) 
TIM4 $C + constant TIM4-DIER ( DMA/Interrupt enable register ) 
TIM4 $10 + constant TIM4-SR ( status register ) 
TIM4 $14 + constant TIM4-EGR ( event generation register ) 
TIM4 $18 + constant TIM4-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM4 $18 + constant TIM4-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM4 $1C + constant TIM4-CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM4 $1C + constant TIM4-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM4 $20 + constant TIM4-CCER ( capture/compare enable  register ) 
TIM4 $24 + constant TIM4-CNT ( counter ) 
TIM4 $28 + constant TIM4-PSC ( prescaler ) 
TIM4 $2C + constant TIM4-ARR ( auto-reload register ) 
TIM4 $34 + constant TIM4-CCR1 ( capture/compare register 1 ) 
TIM4 $38 + constant TIM4-CCR2 ( capture/compare register 2 ) 
TIM4 $3C + constant TIM4-CCR3 ( capture/compare register 3 ) 
TIM4 $40 + constant TIM4-CCR4 ( capture/compare register 4 ) 
TIM4 $48 + constant TIM4-DCR ( DMA control register ) 
TIM4 $4C + constant TIM4-DMAR ( DMA address for full transfer ) 
: TIM4-CR1. ." TIM4-CR1 (read-write) $" TIM4-CR1 @ hex. TIM4-CR1 1b. ;
: TIM4-CR2. ." TIM4-CR2 (read-write) $" TIM4-CR2 @ hex. TIM4-CR2 1b. ;
: TIM4-SMCR. ." TIM4-SMCR (read-write) $" TIM4-SMCR @ hex. TIM4-SMCR 1b. ;
: TIM4-DIER. ." TIM4-DIER (read-write) $" TIM4-DIER @ hex. TIM4-DIER 1b. ;
: TIM4-SR. ." TIM4-SR (read-write) $" TIM4-SR @ hex. TIM4-SR 1b. ;
: TIM4-EGR. ." TIM4-EGR (write-only) $" TIM4-EGR @ hex. TIM4-EGR 1b. ;
: TIM4-CCMR1_Output. ." TIM4-CCMR1_Output (read-write) $" TIM4-CCMR1_Output @ hex. TIM4-CCMR1_Output 1b. ;
: TIM4-CCMR1_Input. ." TIM4-CCMR1_Input (read-write) $" TIM4-CCMR1_Input @ hex. TIM4-CCMR1_Input 1b. ;
: TIM4-CCMR2_Output. ." TIM4-CCMR2_Output (read-write) $" TIM4-CCMR2_Output @ hex. TIM4-CCMR2_Output 1b. ;
: TIM4-CCMR2_Input. ." TIM4-CCMR2_Input (read-write) $" TIM4-CCMR2_Input @ hex. TIM4-CCMR2_Input 1b. ;
: TIM4-CCER. ." TIM4-CCER (read-write) $" TIM4-CCER @ hex. TIM4-CCER 1b. ;
: TIM4-CNT. ." TIM4-CNT (read-write) $" TIM4-CNT @ hex. TIM4-CNT 1b. ;
: TIM4-PSC. ." TIM4-PSC (read-write) $" TIM4-PSC @ hex. TIM4-PSC 1b. ;
: TIM4-ARR. ." TIM4-ARR (read-write) $" TIM4-ARR @ hex. TIM4-ARR 1b. ;
: TIM4-CCR1. ." TIM4-CCR1 (read-write) $" TIM4-CCR1 @ hex. TIM4-CCR1 1b. ;
: TIM4-CCR2. ." TIM4-CCR2 (read-write) $" TIM4-CCR2 @ hex. TIM4-CCR2 1b. ;
: TIM4-CCR3. ." TIM4-CCR3 (read-write) $" TIM4-CCR3 @ hex. TIM4-CCR3 1b. ;
: TIM4-CCR4. ." TIM4-CCR4 (read-write) $" TIM4-CCR4 @ hex. TIM4-CCR4 1b. ;
: TIM4-DCR. ." TIM4-DCR (read-write) $" TIM4-DCR @ hex. TIM4-DCR 1b. ;
: TIM4-DMAR. ." TIM4-DMAR (read-write) $" TIM4-DMAR @ hex. TIM4-DMAR 1b. ;
: TIM4.
TIM4-CR1.
TIM4-CR2.
TIM4-SMCR.
TIM4-DIER.
TIM4-SR.
TIM4-EGR.
TIM4-CCMR1_Output.
TIM4-CCMR1_Input.
TIM4-CCMR2_Output.
TIM4-CCMR2_Input.
TIM4-CCER.
TIM4-CNT.
TIM4-PSC.
TIM4-ARR.
TIM4-CCR1.
TIM4-CCR2.
TIM4-CCR3.
TIM4-CCR4.
TIM4-DCR.
TIM4-DMAR.
;

$40005400 constant I2C1 ( Inter integrated circuit ) 
I2C1 $0 + constant I2C1-CR1 ( Control register 1 ) 
I2C1 $4 + constant I2C1-CR2 ( Control register 2 ) 
I2C1 $8 + constant I2C1-OAR1 ( Own address register 1 ) 
I2C1 $C + constant I2C1-OAR2 ( Own address register 2 ) 
I2C1 $10 + constant I2C1-DR ( Data register ) 
I2C1 $14 + constant I2C1-SR1 ( Status register 1 ) 
I2C1 $18 + constant I2C1-SR2 ( Status register 2 ) 
I2C1 $1C + constant I2C1-CCR ( Clock control register ) 
I2C1 $20 + constant I2C1-TRISE ( TRISE register ) 
: I2C1-CR1. ." I2C1-CR1 (read-write) $" I2C1-CR1 @ hex. I2C1-CR1 1b. ;
: I2C1-CR2. ." I2C1-CR2 (read-write) $" I2C1-CR2 @ hex. I2C1-CR2 1b. ;
: I2C1-OAR1. ." I2C1-OAR1 (read-write) $" I2C1-OAR1 @ hex. I2C1-OAR1 1b. ;
: I2C1-OAR2. ." I2C1-OAR2 (read-write) $" I2C1-OAR2 @ hex. I2C1-OAR2 1b. ;
: I2C1-DR. ." I2C1-DR (read-write) $" I2C1-DR @ hex. I2C1-DR 1b. ;
: I2C1-SR1. ." I2C1-SR1 () $" I2C1-SR1 @ hex. I2C1-SR1 1b. ;
: I2C1-SR2. ." I2C1-SR2 (read-only) $" I2C1-SR2 @ hex. I2C1-SR2 1b. ;
: I2C1-CCR. ." I2C1-CCR (read-write) $" I2C1-CCR @ hex. I2C1-CCR 1b. ;
: I2C1-TRISE. ." I2C1-TRISE (read-write) $" I2C1-TRISE @ hex. I2C1-TRISE 1b. ;
: I2C1.
I2C1-CR1.
I2C1-CR2.
I2C1-OAR1.
I2C1-OAR2.
I2C1-DR.
I2C1-SR1.
I2C1-SR2.
I2C1-CCR.
I2C1-TRISE.
;

$40005800 constant I2C2 ( Inter integrated circuit ) 
I2C2 $0 + constant I2C2-CR1 ( Control register 1 ) 
I2C2 $4 + constant I2C2-CR2 ( Control register 2 ) 
I2C2 $8 + constant I2C2-OAR1 ( Own address register 1 ) 
I2C2 $C + constant I2C2-OAR2 ( Own address register 2 ) 
I2C2 $10 + constant I2C2-DR ( Data register ) 
I2C2 $14 + constant I2C2-SR1 ( Status register 1 ) 
I2C2 $18 + constant I2C2-SR2 ( Status register 2 ) 
I2C2 $1C + constant I2C2-CCR ( Clock control register ) 
I2C2 $20 + constant I2C2-TRISE ( TRISE register ) 
: I2C2-CR1. ." I2C2-CR1 (read-write) $" I2C2-CR1 @ hex. I2C2-CR1 1b. ;
: I2C2-CR2. ." I2C2-CR2 (read-write) $" I2C2-CR2 @ hex. I2C2-CR2 1b. ;
: I2C2-OAR1. ." I2C2-OAR1 (read-write) $" I2C2-OAR1 @ hex. I2C2-OAR1 1b. ;
: I2C2-OAR2. ." I2C2-OAR2 (read-write) $" I2C2-OAR2 @ hex. I2C2-OAR2 1b. ;
: I2C2-DR. ." I2C2-DR (read-write) $" I2C2-DR @ hex. I2C2-DR 1b. ;
: I2C2-SR1. ." I2C2-SR1 () $" I2C2-SR1 @ hex. I2C2-SR1 1b. ;
: I2C2-SR2. ." I2C2-SR2 (read-only) $" I2C2-SR2 @ hex. I2C2-SR2 1b. ;
: I2C2-CCR. ." I2C2-CCR (read-write) $" I2C2-CCR @ hex. I2C2-CCR 1b. ;
: I2C2-TRISE. ." I2C2-TRISE (read-write) $" I2C2-TRISE @ hex. I2C2-TRISE 1b. ;
: I2C2.
I2C2-CR1.
I2C2-CR2.
I2C2-OAR1.
I2C2-OAR2.
I2C2-DR.
I2C2-SR1.
I2C2-SR2.
I2C2-CCR.
I2C2-TRISE.
;

$40013000 constant SPI1 ( Serial peripheral interface ) 
SPI1 $0 + constant SPI1-CR1 ( control register 1 ) 
SPI1 $4 + constant SPI1-CR2 ( control register 2 ) 
SPI1 $8 + constant SPI1-SR ( status register ) 
SPI1 $C + constant SPI1-DR ( data register ) 
SPI1 $10 + constant SPI1-CRCPR ( CRC polynomial register ) 
SPI1 $14 + constant SPI1-RXCRCR ( RX CRC register ) 
SPI1 $18 + constant SPI1-TXCRCR ( TX CRC register ) 
SPI1 $1C + constant SPI1-I2SCFGR ( I2S configuration register ) 
SPI1 $20 + constant SPI1-I2SPR ( I2S prescaler register ) 
: SPI1-CR1. ." SPI1-CR1 (read-write) $" SPI1-CR1 @ hex. SPI1-CR1 1b. ;
: SPI1-CR2. ." SPI1-CR2 (read-write) $" SPI1-CR2 @ hex. SPI1-CR2 1b. ;
: SPI1-SR. ." SPI1-SR () $" SPI1-SR @ hex. SPI1-SR 1b. ;
: SPI1-DR. ." SPI1-DR (read-write) $" SPI1-DR @ hex. SPI1-DR 1b. ;
: SPI1-CRCPR. ." SPI1-CRCPR (read-write) $" SPI1-CRCPR @ hex. SPI1-CRCPR 1b. ;
: SPI1-RXCRCR. ." SPI1-RXCRCR (read-only) $" SPI1-RXCRCR @ hex. SPI1-RXCRCR 1b. ;
: SPI1-TXCRCR. ." SPI1-TXCRCR (read-only) $" SPI1-TXCRCR @ hex. SPI1-TXCRCR 1b. ;
: SPI1-I2SCFGR. ." SPI1-I2SCFGR (read-write) $" SPI1-I2SCFGR @ hex. SPI1-I2SCFGR 1b. ;
: SPI1-I2SPR. ." SPI1-I2SPR (read-write) $" SPI1-I2SPR @ hex. SPI1-I2SPR 1b. ;
: SPI1.
SPI1-CR1.
SPI1-CR2.
SPI1-SR.
SPI1-DR.
SPI1-CRCPR.
SPI1-RXCRCR.
SPI1-TXCRCR.
SPI1-I2SCFGR.
SPI1-I2SPR.
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

$40004400 constant USART2 ( Universal synchronous asynchronous receiver  transmitter ) 
USART2 $0 + constant USART2-SR ( Status register ) 
USART2 $4 + constant USART2-DR ( Data register ) 
USART2 $8 + constant USART2-BRR ( Baud rate register ) 
USART2 $C + constant USART2-CR1 ( Control register 1 ) 
USART2 $10 + constant USART2-CR2 ( Control register 2 ) 
USART2 $14 + constant USART2-CR3 ( Control register 3 ) 
USART2 $18 + constant USART2-GTPR ( Guard time and prescaler  register ) 
: USART2-SR. ." USART2-SR () $" USART2-SR @ hex. USART2-SR 1b. ;
: USART2-DR. ." USART2-DR (read-write) $" USART2-DR @ hex. USART2-DR 1b. ;
: USART2-BRR. ." USART2-BRR (read-write) $" USART2-BRR @ hex. USART2-BRR 1b. ;
: USART2-CR1. ." USART2-CR1 (read-write) $" USART2-CR1 @ hex. USART2-CR1 1b. ;
: USART2-CR2. ." USART2-CR2 (read-write) $" USART2-CR2 @ hex. USART2-CR2 1b. ;
: USART2-CR3. ." USART2-CR3 (read-write) $" USART2-CR3 @ hex. USART2-CR3 1b. ;
: USART2-GTPR. ." USART2-GTPR (read-write) $" USART2-GTPR @ hex. USART2-GTPR 1b. ;
: USART2.
USART2-SR.
USART2-DR.
USART2-BRR.
USART2-CR1.
USART2-CR2.
USART2-CR3.
USART2-GTPR.
;

$40004800 constant USART3 ( Universal synchronous asynchronous receiver  transmitter ) 
USART3 $0 + constant USART3-SR ( Status register ) 
USART3 $4 + constant USART3-DR ( Data register ) 
USART3 $8 + constant USART3-BRR ( Baud rate register ) 
USART3 $C + constant USART3-CR1 ( Control register 1 ) 
USART3 $10 + constant USART3-CR2 ( Control register 2 ) 
USART3 $14 + constant USART3-CR3 ( Control register 3 ) 
USART3 $18 + constant USART3-GTPR ( Guard time and prescaler  register ) 
: USART3-SR. ." USART3-SR () $" USART3-SR @ hex. USART3-SR 1b. ;
: USART3-DR. ." USART3-DR (read-write) $" USART3-DR @ hex. USART3-DR 1b. ;
: USART3-BRR. ." USART3-BRR (read-write) $" USART3-BRR @ hex. USART3-BRR 1b. ;
: USART3-CR1. ." USART3-CR1 (read-write) $" USART3-CR1 @ hex. USART3-CR1 1b. ;
: USART3-CR2. ." USART3-CR2 (read-write) $" USART3-CR2 @ hex. USART3-CR2 1b. ;
: USART3-CR3. ." USART3-CR3 (read-write) $" USART3-CR3 @ hex. USART3-CR3 1b. ;
: USART3-GTPR. ." USART3-GTPR (read-write) $" USART3-GTPR @ hex. USART3-GTPR 1b. ;
: USART3.
USART3-SR.
USART3-DR.
USART3-BRR.
USART3-CR1.
USART3-CR2.
USART3-CR3.
USART3-GTPR.
;

$40012400 constant ADC1 ( Analog to digital converter ) 
ADC1 $0 + constant ADC1-SR ( status register ) 
ADC1 $4 + constant ADC1-CR1 ( control register 1 ) 
ADC1 $8 + constant ADC1-CR2 ( control register 2 ) 
ADC1 $C + constant ADC1-SMPR1 ( sample time register 1 ) 
ADC1 $10 + constant ADC1-SMPR2 ( sample time register 2 ) 
ADC1 $14 + constant ADC1-JOFR1 ( injected channel data offset register  x ) 
ADC1 $18 + constant ADC1-JOFR2 ( injected channel data offset register  x ) 
ADC1 $1C + constant ADC1-JOFR3 ( injected channel data offset register  x ) 
ADC1 $20 + constant ADC1-JOFR4 ( injected channel data offset register  x ) 
ADC1 $24 + constant ADC1-HTR ( watchdog higher threshold  register ) 
ADC1 $28 + constant ADC1-LTR ( watchdog lower threshold  register ) 
ADC1 $2C + constant ADC1-SQR1 ( regular sequence register 1 ) 
ADC1 $30 + constant ADC1-SQR2 ( regular sequence register 2 ) 
ADC1 $34 + constant ADC1-SQR3 ( regular sequence register 3 ) 
ADC1 $38 + constant ADC1-JSQR ( injected sequence register ) 
ADC1 $3C + constant ADC1-JDR1 ( injected data register x ) 
ADC1 $40 + constant ADC1-JDR2 ( injected data register x ) 
ADC1 $44 + constant ADC1-JDR3 ( injected data register x ) 
ADC1 $48 + constant ADC1-JDR4 ( injected data register x ) 
ADC1 $4C + constant ADC1-DR ( regular data register ) 
: ADC1-SR. ." ADC1-SR (read-write) $" ADC1-SR @ hex. ADC1-SR 1b. ;
: ADC1-CR1. ." ADC1-CR1 (read-write) $" ADC1-CR1 @ hex. ADC1-CR1 1b. ;
: ADC1-CR2. ." ADC1-CR2 (read-write) $" ADC1-CR2 @ hex. ADC1-CR2 1b. ;
: ADC1-SMPR1. ." ADC1-SMPR1 (read-write) $" ADC1-SMPR1 @ hex. ADC1-SMPR1 1b. ;
: ADC1-SMPR2. ." ADC1-SMPR2 (read-write) $" ADC1-SMPR2 @ hex. ADC1-SMPR2 1b. ;
: ADC1-JOFR1. ." ADC1-JOFR1 (read-write) $" ADC1-JOFR1 @ hex. ADC1-JOFR1 1b. ;
: ADC1-JOFR2. ." ADC1-JOFR2 (read-write) $" ADC1-JOFR2 @ hex. ADC1-JOFR2 1b. ;
: ADC1-JOFR3. ." ADC1-JOFR3 (read-write) $" ADC1-JOFR3 @ hex. ADC1-JOFR3 1b. ;
: ADC1-JOFR4. ." ADC1-JOFR4 (read-write) $" ADC1-JOFR4 @ hex. ADC1-JOFR4 1b. ;
: ADC1-HTR. ." ADC1-HTR (read-write) $" ADC1-HTR @ hex. ADC1-HTR 1b. ;
: ADC1-LTR. ." ADC1-LTR (read-write) $" ADC1-LTR @ hex. ADC1-LTR 1b. ;
: ADC1-SQR1. ." ADC1-SQR1 (read-write) $" ADC1-SQR1 @ hex. ADC1-SQR1 1b. ;
: ADC1-SQR2. ." ADC1-SQR2 (read-write) $" ADC1-SQR2 @ hex. ADC1-SQR2 1b. ;
: ADC1-SQR3. ." ADC1-SQR3 (read-write) $" ADC1-SQR3 @ hex. ADC1-SQR3 1b. ;
: ADC1-JSQR. ." ADC1-JSQR (read-write) $" ADC1-JSQR @ hex. ADC1-JSQR 1b. ;
: ADC1-JDR1. ." ADC1-JDR1 (read-only) $" ADC1-JDR1 @ hex. ADC1-JDR1 1b. ;
: ADC1-JDR2. ." ADC1-JDR2 (read-only) $" ADC1-JDR2 @ hex. ADC1-JDR2 1b. ;
: ADC1-JDR3. ." ADC1-JDR3 (read-only) $" ADC1-JDR3 @ hex. ADC1-JDR3 1b. ;
: ADC1-JDR4. ." ADC1-JDR4 (read-only) $" ADC1-JDR4 @ hex. ADC1-JDR4 1b. ;
: ADC1-DR. ." ADC1-DR (read-only) $" ADC1-DR @ hex. ADC1-DR 1b. ;
: ADC1.
ADC1-SR.
ADC1-CR1.
ADC1-CR2.
ADC1-SMPR1.
ADC1-SMPR2.
ADC1-JOFR1.
ADC1-JOFR2.
ADC1-JOFR3.
ADC1-JOFR4.
ADC1-HTR.
ADC1-LTR.
ADC1-SQR1.
ADC1-SQR2.
ADC1-SQR3.
ADC1-JSQR.
ADC1-JDR1.
ADC1-JDR2.
ADC1-JDR3.
ADC1-JDR4.
ADC1-DR.
;

$40012800 constant ADC2 ( Analog to digital converter ) 
ADC2 $0 + constant ADC2-SR ( status register ) 
ADC2 $4 + constant ADC2-CR1 ( control register 1 ) 
ADC2 $8 + constant ADC2-CR2 ( control register 2 ) 
ADC2 $C + constant ADC2-SMPR1 ( sample time register 1 ) 
ADC2 $10 + constant ADC2-SMPR2 ( sample time register 2 ) 
ADC2 $14 + constant ADC2-JOFR1 ( injected channel data offset register  x ) 
ADC2 $18 + constant ADC2-JOFR2 ( injected channel data offset register  x ) 
ADC2 $1C + constant ADC2-JOFR3 ( injected channel data offset register  x ) 
ADC2 $20 + constant ADC2-JOFR4 ( injected channel data offset register  x ) 
ADC2 $24 + constant ADC2-HTR ( watchdog higher threshold  register ) 
ADC2 $28 + constant ADC2-LTR ( watchdog lower threshold  register ) 
ADC2 $2C + constant ADC2-SQR1 ( regular sequence register 1 ) 
ADC2 $30 + constant ADC2-SQR2 ( regular sequence register 2 ) 
ADC2 $34 + constant ADC2-SQR3 ( regular sequence register 3 ) 
ADC2 $38 + constant ADC2-JSQR ( injected sequence register ) 
ADC2 $3C + constant ADC2-JDR1 ( injected data register x ) 
ADC2 $40 + constant ADC2-JDR2 ( injected data register x ) 
ADC2 $44 + constant ADC2-JDR3 ( injected data register x ) 
ADC2 $48 + constant ADC2-JDR4 ( injected data register x ) 
ADC2 $4C + constant ADC2-DR ( regular data register ) 
: ADC2-SR. ." ADC2-SR (read-write) $" ADC2-SR @ hex. ADC2-SR 1b. ;
: ADC2-CR1. ." ADC2-CR1 (read-write) $" ADC2-CR1 @ hex. ADC2-CR1 1b. ;
: ADC2-CR2. ." ADC2-CR2 (read-write) $" ADC2-CR2 @ hex. ADC2-CR2 1b. ;
: ADC2-SMPR1. ." ADC2-SMPR1 (read-write) $" ADC2-SMPR1 @ hex. ADC2-SMPR1 1b. ;
: ADC2-SMPR2. ." ADC2-SMPR2 (read-write) $" ADC2-SMPR2 @ hex. ADC2-SMPR2 1b. ;
: ADC2-JOFR1. ." ADC2-JOFR1 (read-write) $" ADC2-JOFR1 @ hex. ADC2-JOFR1 1b. ;
: ADC2-JOFR2. ." ADC2-JOFR2 (read-write) $" ADC2-JOFR2 @ hex. ADC2-JOFR2 1b. ;
: ADC2-JOFR3. ." ADC2-JOFR3 (read-write) $" ADC2-JOFR3 @ hex. ADC2-JOFR3 1b. ;
: ADC2-JOFR4. ." ADC2-JOFR4 (read-write) $" ADC2-JOFR4 @ hex. ADC2-JOFR4 1b. ;
: ADC2-HTR. ." ADC2-HTR (read-write) $" ADC2-HTR @ hex. ADC2-HTR 1b. ;
: ADC2-LTR. ." ADC2-LTR (read-write) $" ADC2-LTR @ hex. ADC2-LTR 1b. ;
: ADC2-SQR1. ." ADC2-SQR1 (read-write) $" ADC2-SQR1 @ hex. ADC2-SQR1 1b. ;
: ADC2-SQR2. ." ADC2-SQR2 (read-write) $" ADC2-SQR2 @ hex. ADC2-SQR2 1b. ;
: ADC2-SQR3. ." ADC2-SQR3 (read-write) $" ADC2-SQR3 @ hex. ADC2-SQR3 1b. ;
: ADC2-JSQR. ." ADC2-JSQR (read-write) $" ADC2-JSQR @ hex. ADC2-JSQR 1b. ;
: ADC2-JDR1. ." ADC2-JDR1 (read-only) $" ADC2-JDR1 @ hex. ADC2-JDR1 1b. ;
: ADC2-JDR2. ." ADC2-JDR2 (read-only) $" ADC2-JDR2 @ hex. ADC2-JDR2 1b. ;
: ADC2-JDR3. ." ADC2-JDR3 (read-only) $" ADC2-JDR3 @ hex. ADC2-JDR3 1b. ;
: ADC2-JDR4. ." ADC2-JDR4 (read-only) $" ADC2-JDR4 @ hex. ADC2-JDR4 1b. ;
: ADC2-DR. ." ADC2-DR (read-only) $" ADC2-DR @ hex. ADC2-DR 1b. ;
: ADC2.
ADC2-SR.
ADC2-CR1.
ADC2-CR2.
ADC2-SMPR1.
ADC2-SMPR2.
ADC2-JOFR1.
ADC2-JOFR2.
ADC2-JOFR3.
ADC2-JOFR4.
ADC2-HTR.
ADC2-LTR.
ADC2-SQR1.
ADC2-SQR2.
ADC2-SQR3.
ADC2-JSQR.
ADC2-JDR1.
ADC2-JDR2.
ADC2-JDR3.
ADC2-JDR4.
ADC2-DR.
;

$E0042000 constant DBG ( Debug support ) 
DBG $0 + constant DBG-IDCODE ( DBGMCU_IDCODE ) 
DBG $4 + constant DBG-CR ( DBGMCU_CR ) 
: DBG-IDCODE. ." DBG-IDCODE (read-only) $" DBG-IDCODE @ hex. DBG-IDCODE 1b. ;
: DBG-CR. ." DBG-CR (read-write) $" DBG-CR @ hex. DBG-CR 1b. ;
: DBG.
DBG-IDCODE.
DBG-CR.
;

$40023000 constant CRC ( CRC calculation unit ) 
CRC $0 + constant CRC-DR ( Data register ) 
CRC $4 + constant CRC-IDR ( Independent Data register ) 
CRC $8 + constant CRC-CR ( Control register ) 
: CRC-DR. ." CRC-DR (read-write) $" CRC-DR @ hex. CRC-DR 1b. ;
: CRC-IDR. ." CRC-IDR (read-write) $" CRC-IDR @ hex. CRC-IDR 1b. ;
: CRC-CR. ." CRC-CR (write-only) $" CRC-CR @ hex. CRC-CR 1b. ;
: CRC.
CRC-DR.
CRC-IDR.
CRC-CR.
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
