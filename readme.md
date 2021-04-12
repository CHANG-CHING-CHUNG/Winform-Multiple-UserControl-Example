# 範例 -  User control 達成多頁切換 & ShowDialog 達成新開視窗並回傳值

## Form1 = 主表單
### 組成
1. LeftSideBar = 左側 panel + table panel + 3個按鈕
2. Content = 右側 panel 用來切換顯示頁面用

## MainContentControl = 第一主頁
裡頭有標題用以顯示此為第一主頁

## SecondContentControl = 第二主頁
裡頭有標題用以顯示此為第一主頁

## PopupForm = 第二表單，用來做 popup 使用
1. 回傳按鈕 = 按下後會設定現在時間的值並回傳 DialogResult.ok 回主表單，主表單在接收到 DialogResult.ok 之後，跳出 MessageBox.Show 並呼叫 PopupForm 裡的現在時間的值顯示