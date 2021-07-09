# <C# 프로젝트>
이 저장소는 C# WinForm 코인데이터, 환율데이터를 사용한 ATM기 프로젝트를 저장한 곳입니다.
- C#는 Visual Studio 2019에서 사용한 환경에서 진행하였습니다.
- DataBase는 MySQL를 사용한 환경에서 진행하였습니다.   

## 제작기간
2021/06/22 ~ 2021/07/12

![img](C_Sharp-Project.png)

## 소개
- C#
    - 기본 폼과 폼 위에 패널 구현
    - 송금 : 송금 전 상대방 계좌 확인, 송금 후 본인 은행계좌 잔액 갱신, 거래내역 갱신 구현
    - 조회 : 본인 정보를 입력, 본인 소유의 모든 계좌 조회 구현
    - 외화 : 당일 환율정보 api를 불러옴, 불러온 api를 기준을 환전기능 구현, 환전 후 해외계좌 잔액, 은행계좌 잔액 갱신 구현
    - 가상화폐 : 가상화폐 거래소 Upbit api를 불러옴, 단위 시간당 새로고침 되는 데이터 차트 구현, 가상화폐 구매 구현, 구매 후 본인 가상화폐 계좌 갱신, 은행계좌 잔액 갱신 구현
- MySQL
    - MySQL Workbench를 활용하여 DB 관리
