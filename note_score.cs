using UnityEngine;
using System.Collections;

public class note_score : MonoBehaviour {

    public GameObject SH_note;
    public GameObject L_note;
    public GameObject SL_note_L;
    public GameObject SL_note_R;
    public GameObject SL_note_U;
    public GameObject SL_note_D;
    float t = 1.2f / 16;

    Vector3 temp;

	void Start () {         // 처음 숫자 1:단노트 / 2:슬라이드L / 3: 슬라이드R / 4: 슬라이드U / 5:슬라이드D
       
        respawn(1, 4, 8*t);     //1
        respawn(1, 4, 10*t);
        respawn(1, 5, 12*t);
        respawn(1, 3, 13*t);
        respawn(1, 5, 14*t);
        respawn(1, 3, 15*t);
        respawn(1, 6, 16*t);    //2
        respawn(1, 3, 18 * t);
        respawn(3, 5, 20 * t);
        respawn(1, 3, 22 * t);
        respawn(1, 4, 24 * t);
        respawn(1, 2, 26 * t);
        respawn(2, 4, 28 * t);
        respawn(1, 3, 30 * t);
        respawn(1, 1, 32 * t);  //3
        respawn(1, 5, 34 * t);
        respawn(1, 3, 36 * t);
        respawn(1, 7, 38 * t);
        respawn(1, 5, 40 * t);
        respawn(1, 4, 42 * t);
        respawn(1, 6, 44 * t);
        respawn(1, 2, 46 * t);
        respawn(3, 4, 48 * t);  //4
        respawn(3, 2, 56 * t);
        respawn(1, 4, 60 * t);
        respawn(4, 8, 64 * t);  //5
        respawn(2, 2, 76 * t);
        respawn(3, 6, 76 * t);                     //
        respawn(1, 7, 80 * t);  //6
        respawn(1, 5, 82 * t);
        respawn(1, 2, 84 * t);
        respawn(1, 4, 86 * t);
        respawn(1, 6, 90 * t);
        respawn(2, 2, 92 * t);
        respawn(1, 8, 94 * t);
        respawn(1, 8, 98 * t);   //7 (96부터 시작 but 2칸 띄워서 시작)
        respawn(2, 2, 100 * t);
        respawn(3, 6, 100 * t);
        respawn(1, 5, 104 * t);
        respawn(1, 7, 108 * t);
        respawn(1, 2, 108 * t);
        respawn(1, 3, 112 * t);
        
        respawn(1, 5, 112 * t); // 8
        respawn(1, 3, 118 * t);
        respawn(1, 5, 118 * t);
        respawn(1, 4, 122 * t);
        respawn(1, 4, 124 * t);
        respawn(1, 4, 126 * t);
        respawn(1, 2, 128 * t);
        respawn(1, 6, 128 * t); //9
        respawn(1, 6, 130 * t);
        respawn(1, 2, 130 * t);
        respawn(2, 1, 134 * t);
        respawn(1, 3, 134 * t);
        respawn(1, 8, 144 * t);   //10   A파트
        respawn(1, 3, 146 * t);
        respawn(3, 6, 148 * t);
        respawn(1, 3, 150 * t);
        respawn(1, 5, 152 * t);
        respawn(1, 2, 154 * t);
        respawn(4, 3, 156 * t);
        respawn(1, 4, 158 * t);
        respawn(1, 6, 160 * t); //11
        respawn(1, 4, 162 * t);
        respawn(2, 2, 164 * t);
        respawn(1, 7, 166 * t);
        respawn(1, 3, 168 * t);
        respawn(3, 5, 170 * t);
        respawn(1, 3, 172 * t);
        respawn(1, 6, 174 * t);
        respawn(1, 1, 176 * t); //12
        respawn(1, 4, 178 * t);
        respawn(1, 3, 180 * t);
        respawn(1, 5, 182 * t);
        respawn(2, 3, 184 * t);
        respawn(1, 6, 186 * t);
        respawn(1, 4, 188 * t);
        respawn(1, 7, 190 * t);
        respawn(3, 2, 192 * t); //13
        respawn(3, 6, 194 * t);
        respawn(3, 3, 196 * t);
        respawn(3, 7, 198 * t);
        respawn(3, 4, 200 * t);
        respawn(1, 2, 204 * t);
        respawn(1, 7, 204 * t);
        respawn(1, 6, 208 * t);   //14
        respawn(1, 5, 210 * t);
        respawn(1, 1, 212 * t);
        respawn(1, 4, 214 * t);
        respawn(1, 6, 218 * t);
        respawn(1, 1, 220 * t);
        respawn(1, 8, 222 * t);
        respawn(1, 8, 226 * t); //15
        respawn(1, 1, 228 * t);
        respawn(1, 6, 228 * t);
        respawn(1, 4, 232 * t);
        respawn(1, 1, 236 * t);
        respawn(1, 5, 236 * t); 
        respawn(1, 2, 240 * t);
        respawn(1, 4, 240 * t); //16
        respawn(1, 2, 242 * t);
        respawn(1, 4, 242 * t);
        respawn(1, 3, 246 * t);
        respawn(1, 5, 246 * t);
        respawn(1, 3, 248 * t);
        respawn(1, 5, 248 * t);
        respawn(1, 4, 252 * t);
        respawn(1, 7, 252 * t);
        respawn(1, 4, 254 * t);
        respawn(1, 7, 254 * t);
        respawn(1, 3, 258 * t); //17
        respawn(1, 5, 258 * t);
        respawn(1, 3, 260 * t);
        respawn(1, 5, 260 * t);
        respawn(1, 1, 264 * t);
        respawn(1, 4, 264 * t);
        respawn(1, 1, 268 * t);
        respawn(3, 6, 268 * t);
        respawn(1, 4, 272 * t); //18
        respawn(1, 2, 274 * t);
        respawn(1, 3, 276 * t);
        respawn(1, 7, 276 * t);
        respawn(1, 5, 278 * t);
        respawn(1, 2, 280 * t);
        respawn(1, 4, 282 * t);
        respawn(1, 2, 284 * t);
        respawn(1, 7, 284 * t);
        respawn(1, 6, 286 * t);
        respawn(1, 4, 288 * t); //19
        respawn(1, 1, 290 * t);
        respawn(1, 3, 292 * t);
        respawn(1, 7, 292 * t);
        respawn(1, 5, 294 * t);
        respawn(1, 2, 296 * t);
        respawn(1, 4, 298 * t);
        respawn(1, 3, 300 * t);
        respawn(1, 6, 302 * t);
        respawn(2, 2, 304 * t); //20
        respawn(1, 4, 306 * t);
        respawn(1, 3, 308 * t);
        respawn(1, 6, 308 * t);
        respawn(1, 5, 310 * t);
        respawn(1, 3, 312 * t);
        respawn(1, 6, 314 * t);
        respawn(1, 2, 316 * t);
        respawn(1, 7, 316 * t);
        respawn(1, 4, 318 * t);
        respawn(1, 1, 320 * t); //21
        respawn(1, 4, 322 * t);
        respawn(1, 2, 324 * t);
        respawn(1, 6, 324 * t);
        respawn(1, 8, 326 * t);
        respawn(1, 3, 328 * t);
        respawn(1, 5, 330 * t);
        respawn(1, 7, 332 * t);
        respawn(1, 2, 332 * t);
        respawn(1, 4, 334 * t);
        respawn(2, 6, 336 * t);   //22
        respawn(1, 3, 338 * t);
        respawn(1, 1, 340 * t);
        respawn(1, 7, 340 * t);
        respawn(1, 5, 342 * t);
        respawn(1, 3, 344 * t);
        respawn(1, 4, 346 * t);
        respawn(1, 1, 348 * t);
        respawn(1, 5, 348 * t);
        respawn(1, 4, 350 * t);
        respawn(1, 3, 352 * t);
        respawn(1, 5, 352 * t); //23
        respawn(1, 7, 356 * t);
        respawn(1, 3, 358 * t);
        respawn(1, 1, 364 * t);
        respawn(1, 3, 368 * t); //24
        respawn(1, 5, 370 * t);
        respawn(1, 1, 372 * t);
        respawn(1, 7, 372 * t);
        respawn(1, 4, 374 * t);
        respawn(1, 2, 376 * t);
        respawn(1, 6, 378 * t);
        respawn(1, 1, 380 * t);
        respawn(1, 4, 380 * t);
        respawn(1, 5, 382 * t);
        respawn(1, 3, 384 * t);
        respawn(1, 6, 384 * t); //25
        respawn(1, 3, 388 * t);
        respawn(1, 6, 388 * t);
        respawn(3, 2, 392 * t);
        respawn(2, 7, 392 * t);
        respawn(2, 2, 396 * t);
        respawn(3, 7, 396 * t);
        respawn(1, 3, 400 * t); //26
        respawn(1, 6, 402 * t);
        respawn(1, 3, 404 * t);
        respawn(1, 6, 406 * t);
        respawn(1, 3, 408 * t);
        respawn(3, 6, 410 * t);
        respawn(1, 3, 412 * t);
        respawn(1, 6, 414 * t);
        respawn(1, 3, 416 * t); //27
        respawn(1, 6, 418 * t);
        respawn(1, 3, 420 * t);
        respawn(1, 6, 422 * t);
        respawn(1, 3, 424 * t);
        respawn(3, 6, 426 * t);        
        respawn(1, 3, 428 * t);
        respawn(2, 7, 429 * t);
        respawn(1, 2, 432 * t); //28
        respawn(1, 6, 434 * t);
        respawn(1, 2, 436 * t);
        respawn(1, 6, 438 * t);
        respawn(1, 2, 440 * t);
        respawn(1, 5, 441 * t);
        respawn(1, 7, 442 * t);
        respawn(1, 2, 444 * t);
        respawn(1, 6, 446 * t);
        respawn(1, 2, 448 * t); //29
        respawn(1, 6, 450 * t);
        respawn(1, 2, 452 * t);
        respawn(1, 6, 454 * t);
        respawn(1, 2, 456 * t);
        respawn(1, 6, 458 * t);
        respawn(1, 2, 460 * t);
        respawn(1, 7, 460 * t);
        respawn(1, 8, 464 * t); //30
        respawn(1, 3, 466 * t);
        respawn(1, 8, 468 * t);
        respawn(1, 3, 470 * t);
        respawn(1, 8, 472 * t);
        respawn(1, 3, 474 * t);
        respawn(1, 5, 475 * t);
        respawn(1, 8, 476 * t);
        respawn(1, 3, 478 * t);
        respawn(1, 8, 480 * t); //31
        respawn(1, 3, 482 * t);
        respawn(1, 8, 484 * t);
        respawn(1, 3, 486 * t);
        respawn(1, 2, 488 * t);
        respawn(1, 8, 488 * t);
        respawn(1, 3, 494 * t);
        respawn(1, 6, 494 * t);
        respawn(1, 7, 496 * t); //32
        respawn(1, 4, 498 * t);
        respawn(1, 7, 500 * t);
        respawn(1, 4, 502 * t);
        respawn(1, 7, 504 * t);
        respawn(3, 3, 505 * t);
        respawn(1, 7, 508 * t);
        respawn(1, 4, 510 * t);
        respawn(1, 7, 512 * t); //33
        respawn(1, 4, 514 * t);
        respawn(1, 7, 516 * t);
        respawn(1, 4, 518 * t);
        respawn(1, 2, 520 * t);
        respawn(1, 7, 520 * t);
        respawn(1, 2, 528 * t); //34
        respawn(1, 3, 530 * t);
        respawn(1, 5, 532 * t);
        respawn(1, 6, 534 * t);
        respawn(1, 8, 536 * t);
        respawn(1, 3, 538 * t);
        respawn(1, 4, 540 * t);
        respawn(1, 5, 542 * t);
        respawn(1, 1, 544 * t); //35
        respawn(1, 3, 546 * t);
        respawn(1, 4, 548 * t);
        respawn(1, 6, 550 * t);
        respawn(1, 5, 552 * t);
        respawn(1, 2, 554 * t);
        respawn(1, 3, 556 * t);
        respawn(1, 6, 558 * t);
        respawn(1, 3, 560 * t); //36
        respawn(1, 4, 562 * t);
        respawn(1, 5, 564 * t);
        respawn(1, 7, 566 * t);
        respawn(1, 3, 568 * t);
        respawn(1, 5, 570 * t);
        respawn(1, 6, 572 * t);
        respawn(1, 3, 574 * t);
        respawn(1, 8, 576 * t); //37
        respawn(1, 6, 578 * t);
        respawn(1, 4, 580 * t);
        respawn(1, 3, 582 * t);
        respawn(1, 5, 584 * t);
        respawn(1, 3, 586 * t);
        respawn(1, 2, 588 * t);
        respawn(1, 7, 588 * t);
        respawn(1, 2, 592 * t); //38
        respawn(1, 4, 594 * t);
        respawn(1, 5, 596 * t);
        respawn(1, 7, 598 * t);
        respawn(1, 8, 600 * t);
        respawn(1, 2, 602 * t);
        respawn(1, 3, 604 * t);
        respawn(1, 6, 606 * t);
        respawn(1, 4, 608 * t); //39
        respawn(1, 2, 610 * t);
        respawn(1, 3, 612 * t);
        respawn(1, 7, 614 * t);
        respawn(1, 5, 616 * t);
        respawn(1, 3, 618 * t);
        respawn(1, 4, 620 * t);
        respawn(1, 6, 622 * t);
        respawn(1, 1, 624 * t); //40
        respawn(1, 3, 626 * t);
        respawn(1, 4, 628 * t);
        respawn(1, 5, 630 * t);
        respawn(1, 3, 632 * t);
        respawn(1, 5, 634 * t);
        respawn(1, 7, 636* t);
        respawn(1, 5, 638 * t);
        respawn(1, 4, 640 * t); //41
        respawn(1, 4, 642 * t);
        respawn(1, 4, 644 * t);
        respawn(1, 3, 646 * t);
        respawn(1, 5, 646 * t);
        respawn(1, 3, 656 * t); //42
        respawn(1, 6, 658 * t);
        respawn(1, 6, 660 * t);
        respawn(1, 3, 662 * t);
        respawn(1, 7, 664 * t);
        respawn(1, 2, 668 * t);
        respawn(1, 4, 668 * t);
        respawn(1, 6, 670 * t);
        respawn(1, 6, 672 * t); //43
        respawn(1, 3, 674 * t);
        respawn(1, 5, 676 * t);
        respawn(1, 5, 678 * t);
        respawn(1, 1, 680 * t);
        respawn(1, 1, 682 * t);
        respawn(1, 3, 684 * t);
        respawn(1, 6, 684 * t);
        respawn(1, 7, 686 * t);
        respawn(1, 2, 688 * t); //44
        respawn(1, 5, 690 * t);
        respawn(1, 5, 692 * t);
        respawn(1, 2, 694 * t);
        respawn(1, 6, 696 * t);
        respawn(1, 1, 700 * t);
        respawn(1, 4, 700 * t);
        respawn(1, 6, 702 * t);
        respawn(1, 2, 704 * t);
        respawn(1, 7, 704 * t); //45
        respawn(1, 2, 708 * t);
        respawn(1, 7, 708 * t);
        respawn(1, 8, 712 * t);
        respawn(1, 6, 714 * t);
        respawn(1, 4, 716 * t);
        respawn(1, 2, 718 * t);
        respawn(1, 1, 720 * t); //46
        respawn(1, 5, 722 * t);
        respawn(1, 5, 724 * t);
        respawn(1, 3, 726 * t);
        respawn(1, 2, 728 * t);
        respawn(1, 5, 732 * t);
        respawn(1, 7, 734 * t);
        respawn(1, 8, 736 * t); //47
        respawn(1, 7, 738 * t);
        respawn(1, 4, 740 * t);
        respawn(1, 3, 744 * t);
        respawn(1, 6, 748 * t);
        respawn(1, 3, 750 * t);
        respawn(1, 5, 750 * t);
        respawn(1, 7, 752 * t); //48
        respawn(1, 3, 754 * t);
        respawn(1, 3, 756 * t);
        respawn(1, 5, 758 * t);
        respawn(1, 2, 760 * t);
        respawn(1, 2, 762 * t);
        respawn(1, 2, 764 * t);
        respawn(1, 6, 766 * t);
        respawn(1, 4, 768 * t); //49
        respawn(1, 3, 772 * t);
        respawn(2, 4, 776 * t);
        respawn(3, 6, 776 * t);
        respawn(4, 3, 784 * t); //50
        respawn(1, 8, 784 * t);
        respawn(1, 6, 786 * t);
        respawn(4, 3, 788 * t);
        respawn(1, 5, 788 * t);
        respawn(4, 3, 792 * t);
        respawn(1, 7, 792 * t);
        respawn(1, 6, 794 * t);
        respawn(4, 2, 796 * t);
        respawn(1, 4, 796 * t);
        respawn(4, 2, 800 * t);
        respawn(1, 7, 800 * t); //51
        respawn(1, 6, 802 * t);
        respawn(4, 2, 804 * t);
        respawn(1, 6, 804 * t);
        respawn(4, 2, 808 * t);
        respawn(1, 6, 808 * t);
        respawn(1, 5, 810 * t);
        respawn(4, 2, 812 * t);
        respawn(1, 4, 812 * t);
        respawn(1, 3, 816 * t);
        respawn(4, 6, 816 * t); //52
        respawn(1, 4, 818 * t);
        respawn(1, 4, 820 * t);
        respawn(4, 6, 820 * t);
        respawn(1, 2, 824 * t); 
        respawn(4, 6, 824 * t);
        respawn(1, 4, 826 * t);
        respawn(1, 5, 828 * t);
        respawn(4, 7, 828 * t);
        respawn(1, 1, 832 * t);
        respawn(4, 7, 832 * t); //53
        respawn(1, 3, 836 * t);
        respawn(1, 4, 838 * t);
        respawn(4, 7, 838 * t);
        respawn(4, 1, 848 * t); //54
        respawn(1, 7, 848 * t);
        respawn(1, 5, 850 * t);
        respawn(4, 1, 852 * t);
        respawn(1, 4, 852 * t);
        respawn(4, 1, 856 * t);
        respawn(1, 7, 856 * t);
        respawn(1, 6, 858 * t);
        respawn(4, 1, 860 * t);
        respawn(1, 4, 860 * t);
        respawn(4, 2, 864 * t);
        respawn(1, 8, 864 * t); //55
        respawn(1, 6, 866 * t);
        respawn(4, 2, 868 * t);
        respawn(1, 5, 868 * t);
        respawn(4, 2, 872 * t);
        respawn(1, 8, 872 * t);
        respawn(1, 7, 874 * t);
        respawn(4, 2, 876 * t);
        respawn(1, 5, 876 * t);
        respawn(2, 4, 880 * t); 
        respawn(4, 7, 880 * t); //56
        respawn(4, 3, 884 * t);
        respawn(3, 5, 884 * t);
        respawn(3, 3, 888 * t);
        respawn(2, 7, 888 * t);
        respawn(2, 3, 892 * t);
        respawn(3, 7, 892 * t);
        respawn(1, 3, 896 * t);
        respawn(1, 6, 896 * t); //57

        respawn(1, 3, 928 * t - 16 * t); // 58
        respawn(1, 5, 930 * t - 16 * t);
        respawn(2, 2, 932 * t - 16 * t);
        respawn(1, 7, 932 * t - 16 * t);
        respawn(1, 8, 934 * t - 16 * t);
        respawn(2, 6, 936 * t - 16 * t);
        respawn(1, 2, 940 * t - 16 * t);
        respawn(1, 4, 940 * t - 16 * t);
        respawn(1, 6, 942 * t - 16 * t);
        respawn(1, 3, 944 * t - 16 * t); // 59
        respawn(3, 6, 946 * t - 16 * t);
        respawn(1, 4, 948 * t - 16 * t);
        respawn(1, 1, 948 * t - 16 * t);
        respawn(1, 7, 950 * t - 16 * t);
        respawn(1, 3, 952 * t - 16 * t);
        respawn(1, 5, 954 * t - 16 * t);
        respawn(1, 2, 956 * t - 16 * t);
        respawn(1, 6, 958 * t - 16 * t);
        respawn(1, 1, 960 * t - 16 * t); // 60
        respawn(1, 8, 960 * t - 16 * t);
        respawn(1, 1, 964 * t - 16 * t);
        respawn(3, 6, 966 * t - 16 * t);
        respawn(1, 1, 968 * t - 16 * t);
        respawn(1, 1, 972 * t - 16 * t);
        respawn(1, 5, 972 * t - 16 * t);
        respawn(1, 2, 976 * t - 16 * t);
        respawn(1, 4, 976 * t - 16 * t);
        respawn(1, 2, 980 * t - 16 * t);
        respawn(4, 4, 982 * t - 16 * t);
        respawn(1, 2, 984 * t - 16 * t);
        respawn(1, 1, 988 * t - 16 * t);
        respawn(1, 3, 988 * t - 16 * t);
        respawn(1, 3, 992 * t - 16 * t); // 62
        respawn(1, 6, 992 * t - 16 * t);
        respawn(4, 6, 996 * t - 16 * t);
        respawn(4, 6, 1000 * t - 16 * t);
        respawn(4, 6, 1004 * t - 16 * t);
        respawn(4, 6, 1008 * t - 16 * t); // 63
        respawn(3, 1, 1010 * t - 16 * t);
        respawn(2, 8, 1012 * t - 16 * t);
        respawn(2, 2, 1014 * t - 16 * t);
        respawn(3, 7, 1016 * t - 16 * t);
        respawn(3, 5, 1018 * t - 16 * t);
        respawn(2, 6, 1020 * t - 16 * t);
        respawn(1, 5, 1022 * t - 16 * t);
        respawn(4, 8, 1024 * t - 16 * t); // 64
        respawn(4, 4, 1024 * t - 16 * t);
        respawn(1, 4, 1030 * t - 16 * t);
        respawn(1, 8, 1030 * t - 16 * t);
        respawn(4, 2, 1036 * t - 16 * t);
        respawn(4, 5, 1036 * t - 16 * t);
        respawn(4, 2, 1042 * t - 16 * t); // 65
        respawn(4, 5, 1042 * t - 16 * t);
        respawn(1, 1, 1048 * t - 16 * t);
        respawn(1, 6, 1048 * t - 16 * t);
        respawn(4, 1, 1052 * t - 16 * t);
        respawn(4, 7, 1052 * t - 16 * t);
        respawn(1, 8, 1056 * t - 16 * t); //66
        respawn(1, 2, 1058 * t - 16 * t);
        respawn(1, 4, 1060 * t - 16 * t);
        respawn(1, 5, 1062 * t - 16 * t);
        respawn(1, 6, 1064 * t - 16 * t);
        respawn(1, 2, 1066 * t - 16 * t);
        respawn(1, 4, 1068 * t - 16 * t);
        respawn(1, 7, 1070 * t - 16 * t);
        respawn(1, 6, 1074 * t - 16 * t); // 67
        respawn(1, 3, 1076 * t - 16 * t);
        respawn(1, 6, 1078 * t - 16 * t);
        respawn(1, 6, 1082 * t - 16 * t);
        respawn(1, 3, 1084 * t - 16 * t);
        respawn(1, 5, 1084 * t - 16 * t);
        respawn(1, 7, 1086 * t - 16 * t);
        respawn(1, 6, 1088 * t - 16 * t);//68
        respawn(1, 1, 1090 * t - 16 * t);
        respawn(1, 3, 1092 * t - 16 * t);
        respawn(1, 5, 1094 * t - 16 * t);
        respawn(1, 6, 1096 * t - 16 * t);
        respawn(1, 2, 1098 * t - 16 * t);
        respawn(1, 4, 1100 * t - 16 * t);
        respawn(1, 7, 1102 * t - 16 * t);
        respawn(1, 7, 1106 * t - 16 * t); //69
        respawn(1, 2, 1108 * t - 16 * t);
        respawn(1, 7, 1110 * t - 16 * t);
        respawn(1, 9, 1114 * t - 16 * t);
        respawn(1, 2, 1116 * t - 16 * t);
        respawn(1, 8, 1116 * t - 16 * t);
        respawn(1, 5, 1118 * t - 16 * t);
        respawn(1, 5, 1120 * t - 16 * t); //70
        respawn(1, 3, 1122 * t - 16 * t);
        respawn(1, 4, 1124 * t - 16 * t);
        respawn(1, 6, 1126 * t - 16 * t);
        respawn(1, 8, 1128 * t - 16 * t);
        respawn(1, 4, 1130 * t - 16 * t);
        respawn(1, 7, 1132 * t - 16 * t);
        respawn(1, 9, 1134 * t - 16 * t);
        respawn(1, 9, 1138 * t - 16 * t); //71
        respawn(1, 5, 1140 * t - 16 * t);
        respawn(1, 9, 1142 * t - 16 * t);
        respawn(1, 1, 1146 * t - 16 * t);
        respawn(1, 2, 1148 * t - 16 * t);
        respawn(1, 7, 1148 * t - 16 * t);
        respawn(1, 4, 1150 * t - 16 * t);
        respawn(1, 6, 1152 * t - 16 * t); //72
        respawn(1, 3, 1154 * t - 16 * t);
        respawn(1, 5, 1156 * t - 16 * t);
        respawn(1, 6, 1158 * t - 16 * t);
        respawn(1, 8, 1160 * t - 16 * t);
        respawn(1, 4, 1162 * t - 16 * t);
        respawn(1, 7, 1164 * t - 16 * t);
        respawn(1, 7, 1166 * t - 16 * t);
        respawn(1, 3, 1168 * t - 16 * t); //73
        respawn(1, 7, 1170 * t - 16 * t);
        respawn(1, 2, 1172 * t - 16 * t);
        respawn(1, 5, 1174 * t - 16 * t);
        respawn(1, 7, 1176 * t - 16 * t);
        respawn(1, 1, 1178 * t - 16 * t);
        respawn(1, 6, 1180 * t - 16 * t);
        respawn(1, 1, 1182 * t - 16 * t);
        respawn(1, 3, 1184 * t - 16 * t); //74
        respawn(1, 5, 1186 * t - 16 * t);
        respawn(1, 6, 1188 * t - 16 * t);
        respawn(1, 8, 1190 * t - 16 * t);
        respawn(1, 3, 1192 * t - 16 * t);
        respawn(1, 5, 1194 * t - 16 * t);
        respawn(1, 6, 1196 * t - 16 * t);
        respawn(1, 8, 1198 * t - 16 * t);
        respawn(1, 2, 1200 * t - 16 * t); //75
        respawn(1, 4, 1202 * t - 16 * t);
        respawn(1, 5, 1204 * t - 16 * t);
        respawn(1, 7, 1206 * t - 16 * t);
        respawn(1, 2, 1208 * t - 16 * t);
        respawn(1, 4, 1210 * t - 16 * t);
        respawn(1, 5, 1212 * t - 16 * t);
        respawn(1, 7, 1214 * t - 16 * t);
        respawn(1, 1, 1216 * t - 16 * t); //76
        respawn(1, 6, 1218 * t - 16 * t);
        respawn(1, 2, 1220 * t - 16 * t);
        respawn(1, 7, 1222 * t - 16 * t);
        respawn(1, 3, 1224 * t - 16 * t);
        respawn(1, 8, 1226 * t - 16 * t);
        respawn(1, 4, 1228 * t - 16 * t);
        respawn(1, 9, 1230 * t - 16 * t);
        respawn(1, 5, 1232 * t - 16 * t); //77
        respawn(1, 5, 1234 * t - 16 * t);
        respawn(1, 8, 1236 * t - 16 * t);
        respawn(1, 8, 1238 * t - 16 * t);
        respawn(1, 3, 1240 * t - 16 * t);
        respawn(3, 6, 1241 * t - 16 * t);
        respawn(1, 3, 1242 * t - 16 * t);
        respawn(1, 6, 1244 * t - 16 * t);
        respawn(2, 3, 1245 * t - 16 * t);
        respawn(1, 6, 1246 * t - 16 * t);


        respawn(1, 2, 1248 * t - 16 * t);  //78
        respawn(1, 6, 1248 * t - 16 * t);
        respawn(1, 5, 1250 * t - 16 * t);
        respawn(1, 2, 1252 * t - 16 * t);
        respawn(1, 6, 1252 * t - 16 * t);
        respawn(1, 2, 1256 * t - 16 * t);
        respawn(1, 7, 1256 * t - 16 * t);
        respawn(1, 5, 1258 * t - 16 * t);
        respawn(1, 2, 1260 * t - 16 * t);
        respawn(1, 7, 1260 * t - 16 * t);

        respawn(1, 1, 1264 * t - 16 * t); //79
        respawn(1, 8, 1264 * t - 16 * t);
        respawn(1, 6, 1266 * t - 16 * t);
        respawn(1, 1, 1268 * t - 16 * t);
        respawn(1, 8, 1268 * t - 16 * t);
        respawn(1, 1, 1272 * t - 16 * t);
        respawn(1, 7, 1272 * t - 16 * t);
        respawn(1, 6, 1274 * t - 16 * t);
        respawn(1, 1, 1276 * t - 16 * t);
        respawn(1, 7, 1276 * t - 16 * t);
        respawn(1, 3, 1280 * t - 16 * t); //80
        respawn(1, 6, 1280 * t - 16 * t);
        respawn(1, 8, 1282 * t - 16 * t);
        respawn(1, 3, 1284 * t - 16 * t);
        respawn(1, 6, 1284 * t - 16 * t);
        respawn(1, 3, 1288 * t - 16 * t);
        respawn(1, 5, 1288 * t - 16 * t);
        respawn(1, 7, 1290 * t - 16 * t);
        respawn(1, 3, 1292 * t - 16 * t);
        respawn(1, 5, 1292 * t - 16 * t);
        respawn(1, 2, 1296 * t - 16 * t); //81
        respawn(1, 8, 1296 * t - 16 * t);
        respawn(1, 2, 1300 * t - 16 * t);
        respawn(1, 8, 1300 * t - 16 * t);
        respawn(1, 9, 1304 * t - 16 * t);
        respawn(1, 7, 1306 * t - 16 * t);
        respawn(1, 5, 1308 * t - 16 * t);
        respawn(1, 3, 1310 * t - 16 * t);
        respawn(1, 1, 1312 * t - 16 * t); // 82
        respawn(1, 7, 1312 * t - 16 * t);
        respawn(1, 3, 1314 * t - 16 * t);
        respawn(1, 1, 1316 * t - 16 * t);
        respawn(1, 7, 1316 * t - 16 * t);
        respawn(1, 2, 1320 * t - 16 * t);
        respawn(1, 7, 1320 * t - 16 * t);
        respawn(1, 3, 1322 * t - 16 * t);
        respawn(1, 2, 1324 * t - 16 * t);
        respawn(1, 7, 1324 * t - 16 * t);
        respawn(1, 3, 1328 * t - 16 * t); //83
        respawn(1, 8, 1328 * t - 16 * t);
        respawn(1, 5, 1330 * t - 16 * t);
        respawn(1, 3, 1332 * t - 16 * t);
        respawn(1, 8, 1332 * t - 16 * t);
        respawn(1, 4, 1336 * t - 16 * t);
        respawn(1, 8, 1336 * t - 16 * t);
        respawn(1, 5, 1338 * t - 16 * t);
        respawn(1, 4, 1340 * t - 16 * t);
        respawn(1, 8, 1340 * t - 16 * t);
        respawn(1, 6, 1344 * t - 16 * t);
        respawn(1, 6, 1346 * t - 16 * t);
        respawn(1, 2, 1348 * t - 16 * t);
        respawn(1, 2, 1350 * t - 16 * t);
        respawn(1, 4, 1352 * t - 16 * t);
        respawn(1, 4, 1354 * t - 16 * t);
        respawn(1, 4, 1356 * t - 16 * t);
        respawn(1, 7, 1358 * t - 16 * t);
        respawn(1, 3, 1360 * t - 16 * t); //85
        respawn(1, 6, 1362 * t - 16 * t);
        respawn(1, 4, 1364 * t - 16 * t);
        respawn(1, 8, 1366 * t - 16 * t);
        respawn(1, 5, 1368 * t - 16 * t);
        respawn(1, 9, 1368 * t - 16 * t);
        respawn(1, 5, 1372 * t - 16 * t);
        respawn(1, 9, 1372 * t - 16 * t);
        respawn(1, 3, 1376 * t - 16 * t); // 86
        respawn(1, 7, 1378 * t - 16 * t);
        respawn(1, 7, 1380 * t - 16 * t);
        respawn(1, 2, 1382 * t - 16 * t);
        respawn(1, 7, 1384 * t - 16 * t);
        respawn(1, 4, 1388 * t - 16 * t);
        respawn(1, 6, 1388 * t - 16 * t);
        respawn(1, 8, 1390 * t - 16 * t);
        respawn(1, 8, 1392 * t - 16 * t); //87
        respawn(1, 3, 1394 * t - 16 * t);
        respawn(1, 7, 1396 * t - 16 * t);
        respawn(1, 7, 1398 * t - 16 * t);
        respawn(1, 1, 1400 * t - 16 * t);
        respawn(1, 1, 1402 * t - 16 * t);
        respawn(1, 3, 1404 * t - 16 * t);
        respawn(1, 5, 1404 * t - 16 * t);
        respawn(1, 7, 1406 * t - 16 * t);
        respawn(1, 2, 1408 * t - 16 * t); // 88
        respawn(1, 6, 1410 * t - 16 * t);
        respawn(1, 6, 1412 * t - 16 * t);
        respawn(1, 4, 1414 * t - 16 * t);
        respawn(1, 9, 1416 * t - 16 * t);
        respawn(1, 3, 1420 * t - 16 * t);
        respawn(1, 5, 1420 * t - 16 * t);
        respawn(1, 8, 1422 * t - 16 * t);
        respawn(1, 2, 1424 * t - 16 * t); //89
        respawn(1, 6, 1426 * t - 16 * t);
        respawn(1, 4, 1428 * t - 16 * t);
        respawn(1, 6, 1430 * t - 16 * t);
        respawn(1, 1, 1432 * t - 16 * t);
        respawn(2, 7, 1434 * t - 16 * t);
        respawn(1, 1, 1436 * t - 16 * t);
        respawn(2, 7, 1438 * t - 16 * t);
        respawn(1, 2, 1440 * t - 16 * t); //90
        respawn(1, 5, 1442 * t - 16 * t);
        respawn(1, 5, 1444 * t - 16 * t);
        respawn(1, 3, 1446 * t - 16 * t);
        respawn(1, 7, 1448 * t - 16 * t);
        respawn(1, 2, 1452 * t - 16 * t);
        respawn(1, 4, 1452 * t - 16 * t);
        respawn(1, 9, 1454 * t - 16 * t);
        respawn(1, 8, 1456 * t - 16 * t); //91
        respawn(1, 9, 1458 * t - 16 * t);
        respawn(1, 5, 1460 * t - 16 * t);
        respawn(1, 3, 1464 * t - 16 * t);
        respawn(1, 7, 1466 * t - 16 * t);
        respawn(1, 3, 1468 * t - 16 * t);
        respawn(1, 5, 1468 * t - 16 * t);
        respawn(1, 8, 1470 * t - 16 * t);
        respawn(1, 2, 1472 * t - 16 * t); //92
        respawn(1, 5, 1473 * t - 16 * t);
        respawn(1, 2, 1474 * t - 16 * t);
        respawn(1, 5, 1475 * t - 16 * t);
        respawn(1, 3, 1478 * t - 16 * t);
        respawn(1, 6, 1479 * t - 16 * t);
        respawn(1, 3, 1480 * t - 16 * t);
        respawn(1, 6, 1481 * t - 16 * t);
        respawn(1, 4, 1484 * t - 16 * t);
        respawn(1, 7, 1485 * t - 16 * t);
        respawn(1, 4, 1486 * t - 16 * t);
        respawn(1, 7, 1487 * t - 16 * t);
        respawn(1, 5, 1490 * t - 16 * t); //93
        respawn(1, 8, 1491 * t - 16 * t);
        respawn(1, 5, 1492 * t - 16 * t);
        respawn(1, 8, 1493 * t - 16 * t);      //드르르륻ㄱ
        respawn(1, 1, 1496 * t - 16 * t);
        respawn(1, 9, 1496 * t - 16 * t);
        respawn(1, 1, 1500 * t - 16 * t);
        respawn(1, 9, 1500 * t - 16 * t);
        respawn(1, 1, 1504 * t - 16 * t); // 94  //폭타시작
        respawn(1, 7, 1504 * t - 16 * t);
        respawn(1, 4, 1506 * t - 16 * t);
        respawn(1, 6, 1507 * t - 16 * t);
        respawn(1, 3, 1508 * t - 16 * t);
        respawn(1, 7, 1509 * t - 16 * t);
        respawn(1, 3, 1510 * t - 16 * t);
        respawn(1, 4, 1511 * t - 16 * t);
        respawn(1, 2, 1512 * t - 16 * t);
        respawn(1, 5, 1513 * t - 16 * t);
        respawn(1, 2, 1514 * t - 16 * t);
        respawn(1, 4, 1515 * t - 16 * t);
        respawn(1, 3, 1516 * t - 16 * t);
        respawn(1, 8, 1517 * t - 16 * t);
        respawn(1, 2, 1518 * t - 16 * t);
        respawn(1, 8, 1519 * t - 16 * t);
        respawn(1, 1, 1520 * t - 16 * t); //95
        respawn(1, 5, 1521 * t - 16 * t);
        respawn(1, 2, 1522 * t - 16 * t);
        respawn(1, 4, 1523 * t - 16 * t);
        respawn(1, 1, 1524 * t - 16 * t);
        respawn(1, 7, 1525 * t - 16 * t);
        respawn(1, 3, 1526 * t - 16 * t);
        respawn(1, 8, 1527 * t - 16 * t);
        respawn(1, 3, 1528 * t - 16 * t);
        respawn(1, 6, 1529 * t - 16 * t);
        respawn(1, 2, 1530 * t - 16 * t);
        respawn(1, 4, 1531 * t - 16 * t);
        respawn(1, 1, 1532 * t - 16 * t);
        respawn(1, 5, 1533 * t - 16 * t);
        respawn(1, 1, 1534 * t - 16 * t);
        respawn(1, 7, 1535 * t - 16 * t);
        respawn(1, 2, 1536 * t - 16 * t); //96
        respawn(1, 6, 1537 * t - 16 * t);
        respawn(1, 1, 1538 * t - 16 * t);
        respawn(1, 8, 1539 * t - 16 * t);
        respawn(1, 1, 1540 * t - 16 * t);
        respawn(1, 3, 1541 * t - 16 * t);
        respawn(1, 1, 1542 * t - 16 * t);
        respawn(1, 6, 1543 * t - 16 * t);
        respawn(1, 3, 1544 * t - 16 * t);
        respawn(1, 7, 1545 * t - 16 * t);
        respawn(1, 4, 1546 * t - 16 * t);
        respawn(1, 8, 1547 * t - 16 * t);
        respawn(1, 3, 1548 * t - 16 * t);
        respawn(1, 8, 1549 * t - 16 * t);
        respawn(1, 4, 1550 * t - 16 * t);
        respawn(1, 7, 1551 * t - 16 * t);
        respawn(1, 1, 1552 * t - 16 * t); //97
        respawn(1, 8, 1553 * t - 16 * t);
        respawn(1, 2, 1554 * t - 16 * t);
        respawn(1, 7, 1555 * t - 16 * t);
        respawn(1, 3, 1556 * t - 16 * t);
        respawn(1, 6, 1557 * t - 16 * t);
        respawn(1, 4, 1558 * t - 16 * t);
        respawn(1, 5, 1559 * t - 16 * t);
        respawn(1, 3, 1560 * t - 16 * t);
        respawn(1, 6, 1561 * t - 16 * t);
        respawn(1, 2, 1562 * t - 16 * t);
        respawn(1, 7, 1563 * t - 16 * t);
        respawn(1, 1, 1564 * t - 16 * t);
        respawn(1, 8, 1564 * t - 16 * t);                //폭타끝
        respawn(1, 7, 1568 * t - 16 * t); //98
        respawn(1, 6, 1570 * t - 16 * t);
        respawn(1, 4, 1572 * t - 16 * t);
        respawn(1, 5, 1574 * t - 16 * t);
        respawn(1, 6, 1578 * t - 16 * t);
        respawn(1, 4, 1580 * t - 16 * t);
        respawn(1, 9, 1582 * t - 16 * t);
        respawn(1, 9, 1586 * t - 16 * t);
        respawn(1, 3, 1588 * t - 16 * t);
        respawn(1, 7, 1588 * t - 16 * t);
        respawn(1, 5, 1592 * t - 16 * t);
        respawn(1, 3, 1596 * t - 16 * t);
        respawn(1, 7, 1596 * t - 16 * t);
        respawn(1, 2, 1600 * t - 16 * t); // 100
        respawn(1, 6, 1600 * t - 16 * t);
        respawn(1, 2, 1606 * t - 16 * t);
        respawn(1, 7, 1606 * t - 16 * t);
        respawn(1, 4, 1612 * t - 16 * t);
        respawn(1, 8, 1612 * t - 16 * t);
        respawn(1, 3, 1618 * t - 16 * t); // 101
        respawn(1, 8, 1618 * t - 16 * t);
        respawn(1, 3, 1624 * t - 16 * t);
        respawn(1, 9, 1624 * t - 16 * t);
        respawn(1, 5, 1628 * t - 16 * t);
        respawn(1, 7, 1628 * t - 16 * t);
        respawn(1, 2, 1632 * t - 16 * t);
        respawn(1, 8, 1632 * t - 16 * t);

    }


    void Update () {
        temp = transform.position;
	
	}


    void respawn(int a, int b, float c)                                       // a = 노트 종류, b = 위치, c = 시간
    {
        if (a == 1)
        {
            if (b == 1)
            {
                Invoke("SH_res1", c);
            }
            if (b == 2)
            {
                Invoke("SH_res2", c);
            }
            if (b == 3)
            {
                Invoke("SH_res3", c);
            }
            if (b == 4)
            {
                Invoke("SH_res4", c);
            }
            if (b == 5)
            {
                Invoke("SH_res5", c);
            }
            if (b == 6)
            {
                Invoke("SH_res6", c);
            }
            if (b == 7)
            {
                Invoke("SH_res7", c);
            }
            if (b == 8)
            {
                Invoke("SH_res8", c);
            }
        }

        if (a == 2)
        {
            if (b == 1)
            {
                Invoke("SL_res1_L", c);
            }
            if (b == 2)
            {
                Invoke("SL_res2_L", c);
            }
            if (b == 3)
            {
                Invoke("SL_res3_L", c);
            }
            if (b == 4)
            {
                Invoke("SL_res4_L", c);
            }
            if (b == 5)
            {
                Invoke("SL_res5_L", c);
            }
            if (b == 6)
            {
                Invoke("SL_res6_L", c);
            }
            if (b == 7)
            {
                Invoke("SL_res7_L", c);
            }
            if (b == 8)
            {
                Invoke("SL_res8_L", c);
            }
        }

        if (a == 3)
        {
            if (b == 1)
            {
                Invoke("SL_res1_R", c);
            }
            if (b == 2)
            {
                Invoke("SL_res2_R", c);
            }
            if (b == 3)
            {
                Invoke("SL_res3_R", c);
            }
            if (b == 4)
            {
                Invoke("SL_res4_R", c);
            }
            if (b == 5)
            {
                Invoke("SL_res5_R", c);
            }
            if (b == 6)
            {
                Invoke("SL_res6_R", c);
            }
            if (b == 7)
            {
                Invoke("SL_res7_R", c);
            }
            if (b == 8)
            {
                Invoke("SL_res8_R", c);
            }
        }

        if (a == 4)
        {
            if (b == 1)
            {
                Invoke("SL_res1_U", c);
            }
            if (b == 2)
            {
                Invoke("SL_res2_U", c);
            }
            if (b == 3)
            {
                Invoke("SL_res3_U", c);
            }
            if (b == 4)
            {
                Invoke("SL_res4_U", c);
            }
            if (b == 5)
            {
                Invoke("SL_res5_U", c);
            }
            if (b == 6)
            {
                Invoke("SL_res6_U", c);
            }
            if (b == 7)
            {
                Invoke("SL_res7_U", c);
            }
            if (b == 8)
            {
                Invoke("SL_res8_U", c);
            }
        }
    }


    
    //////////////////////////////////////////////////////////////
    


    void SH_res1() {
        Instantiate(SH_note, transform.position, transform.rotation);
    }
    void SH_res2() {
        Instantiate(SH_note, new Vector3(temp.x + 1.5f, temp.y, temp.z), transform.rotation);
    }
    void SH_res3() {
        Instantiate(SH_note, new Vector3(temp.x + 3, temp.y, temp.z), transform.rotation);
    }
    void SH_res4() {
        Instantiate(SH_note, new Vector3(temp.x + 4.5f, temp.y, temp.z), transform.rotation);
    }
    void SH_res5() {
        Instantiate(SH_note, new Vector3(temp.x + 6, temp.y, temp.z), transform.rotation);
    }
    void SH_res6() {
        Instantiate(SH_note, new Vector3(temp.x + 7.5f, temp.y, temp.z), transform.rotation);
    }
    void SH_res7() {
        Instantiate(SH_note, new Vector3(temp.x + 9, temp.y, temp.z), transform.rotation);
    }
    void SH_res8() {
        Instantiate(SH_note, new Vector3(temp.x + 10.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res1_R() {
        Instantiate(SL_note_R, transform.position, transform.rotation);
    }
    void SL_res2_R() {
        Instantiate(SL_note_R, new Vector3(temp.x + 1.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res3_R() {
        Instantiate(SL_note_R, new Vector3(temp.x + 3, temp.y, temp.z), transform.rotation);
    }
    void SL_res4_R() {
        Instantiate(SL_note_R, new Vector3(temp.x + 4.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res5_R() {
        Instantiate(SL_note_R, new Vector3(temp.x + 6, temp.y, temp.z), transform.rotation);
    }
    void SL_res6_R() {
        Instantiate(SL_note_R, new Vector3(temp.x + 7.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res7_R() {
        Instantiate(SL_note_R, new Vector3(temp.x + 9, temp.y, temp.z), transform.rotation);
    }
    void SL_res8_R() {
        Instantiate(SL_note_R, new Vector3(temp.x + 10.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res1_L() {
        Instantiate(SL_note_L, transform.position, transform.rotation);
    }
    void SL_res2_L() {
        Instantiate(SL_note_L, new Vector3(temp.x + 1.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res3_L() {
        Instantiate(SL_note_L, new Vector3(temp.x + 3, temp.y, temp.z), transform.rotation);
    }
    void SL_res4_L() {
        Instantiate(SL_note_L, new Vector3(temp.x + 4.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res5_L() {
        Instantiate(SL_note_L, new Vector3(temp.x + 6, temp.y, temp.z), transform.rotation);
    }
    void SL_res6_L() {
        Instantiate(SL_note_L, new Vector3(temp.x + 7.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res7_L() {
        Instantiate(SL_note_L, new Vector3(temp.x + 9, temp.y, temp.z), transform.rotation);
    }
    void SL_res8_L() {
        Instantiate(SL_note_L, new Vector3(temp.x + 10.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res1_U()
    {
        Instantiate(SL_note_U, transform.position, transform.rotation);
    }
    void SL_res2_U()
    {
        Instantiate(SL_note_U, new Vector3(temp.x + 1.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res3_U()
    {
        Instantiate(SL_note_U, new Vector3(temp.x + 3, temp.y, temp.z), transform.rotation);
    }
    void SL_res4_U()
    {
        Instantiate(SL_note_U, new Vector3(temp.x + 4.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res5_U()
    {
        Instantiate(SL_note_U, new Vector3(temp.x + 6, temp.y, temp.z), transform.rotation);
    }
    void SL_res6_U()
    {
        Instantiate(SL_note_U, new Vector3(temp.x + 7.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res7_U()
    {
        Instantiate(SL_note_U, new Vector3(temp.x + 9, temp.y, temp.z), transform.rotation);
    }
    void SL_res8_U()
    {
        Instantiate(SL_note_U, new Vector3(temp.x + 10.5f, temp.y, temp.z), transform.rotation);
    }

    /////////////////////////////////////////////////////////////////////
}
