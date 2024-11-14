# Metal Adventure
[UI](UI)

[AI](AI)

[Scriptable Object](Scriptable-Object)

## UI
게임 시작 시 좌측 상단에 현재 골드와 상단에 현재 스테이지가 보이도록 배치했습니다.
![image](https://github.com/xoxohoon01/Metal-Adventure/blob/main/UI_1.png)

아이템샵 오브젝트를 활성화 하면 아이템을 구매할 수 있는 UI가 표시됩니다.
![image](https://github.com/xoxohoon01/Metal-Adventure/blob/main/UI_2.png)

인벤토리와 장비 오브젝트를 활성화 화면 인벤토리와 장비창이 표시됩니다.
![image](https://github.com/xoxohoon01/Metal-Adventure/blob/main/UI_3.png)


게임 시작시 인벤토리 오브젝트의 하위 오브젝트가 생성되는데, 슬롯 오브젝트가 생성되며 슬롯 오브젝트의 컴포넌트 중 InventorySlot 클래스의 Item은 Scriptable Object로 프로젝트 폴더 내에 Item을 드래그앤 드롭으로 넣어주면 실시간으로 이미지가 변화합니다.
![image](https://github.com/xoxohoon01/Metal-Adventure/blob/main/UI_5.png)
![image](https://github.com/xoxohoon01/Metal-Adventure/blob/main/UI_4.png)

## AI
캐릭터가 몬스터를 추적하는 AI는 interface를 활용하여 구현했습니다.
![image](https://github.com/xoxohoon01/Metal-Adventure/blob/main/AI_1.gif)

State 자체를 클래스로 구분지었으며, PlayerController에서 currentState를 바꾸어 상태를 전환합니다.
Idle상태, Move상태, Attack상태가 있으며 Idle은 몬스터가 인식범위 밖에 있을 때, Move는 인식 후 공격범위에 들어올때까지 이동할 때, Attack은 몬스터가 공격범위 안에 들어왔을 때 공격하는 상태가 되도록 구현했습니다.

![image](https://github.com/xoxohoon01/Metal-Adventure/blob/main/AI_2.png)
![image](https://github.com/xoxohoon01/Metal-Adventure/blob/main/AI_3.png)
상태에 따라 Update에서 실행될 기능을 달리하여 상태에 따른 행동패턴을 다르게 구현했습니다.

## Scriptable Object
프로젝트 내에서 사용되는 Scriptable Object는 캐릭터 종류, 몬스터 종류, 아이템으로 구분지었습니다.

![image](https://github.com/xoxohoon01/Metal-Adventure/blob/main/SO_1.png)
