# VRInteriorEditor
### 📋개발내용


### 1. NewInputSystem을 활용하여 VR컨트롤러의 버튼에 새로운 기능 할당
- UI on/off
- 오브젝트 설치
- 생성된 오브젝트 회전
- 오브젝트 선택
### 2. Raycast사용하여 오브젝트 벽 또는 바닥에 생성
- 오른쪽 컨트롤러에서 정면으로 Ray를 생성하고 바닥 또는 벽과 충돌 하였을 때 충돌한 지점의 좌표를 저장하여 그 좌표에 UI에서 선택한 오브젝트 생성
- 벽과 바닥을 구분하여 생성된 Ray가 어느 콜라이더에 충돌했는지에 따라 그에 맞는 오브젝트를 생성(ex. 바닥에 올려 놓는 오브젝트는 벽과 Ray가 충돌시 스폰되지 않음)
- 방향 별로 벽의 레이어를 구분하여(좌, 우, 뒤) 어떤 방향의 벽에 Ray가 충돌했는지에 따라서 생성되는 오브젝트의 회전값을 조절(ex. 오른쪽 벽과 충돌 시 소환되는 오브젝트 y축으로 90도 회전)
### 3. 열거형으로 현재 상태 관리
- 현재 상태를 Normal, Build, Edit으로 나누어 열거형으로 관리
- UI에서 생성하고자 하는 오브젝트를 선택할 때 Build로 현재 상태 변경
- Build상태 일 때 Ray가 지정된 Layer와 충돌하면 충돌한 지점에 선택한 오브젝트 생성, 생성 후에는 다시 Normal로 변경되며 Ray가 충돌해도 오브젝트가 생성되지 않음
- Edit 버튼 클릭 시 Edit모드로 현재 상태 전환
- Edit모드에서 이미 생성된 오브젝트 Grab버튼으로 선택 가능, 선택하면 Edit UI가 켜지고 오브젝트를 재배치 할 수 있음
- 다시 UI에서 생성하고자 하는 오브젝트를 클릭하면 Build 상태로 전환
