# GIFT ARrow（仮）

[![Product Name](image.png)](https://www.youtube.com/watch?v=G5rULR53uMk)

## 製品概要
### プレゼント×Tech（AR）

### 背景（製品開発のきっかけ、課題等）
#### プレゼントを送る体験をもっとよくできる！

私たちは単身赴任で遠く離れた家族や、遠距離恋愛のカップルの抱えている「もっと心理的な障壁を無くしたい！」というニーズを満たしたり、解決したい。

本プロダクトでは、様々なプレゼントにARを表示させる機能をつけ、自分の送りたいメッセージをキャラクターに話してもらうサービスを提供します。

ファン向けのメッセージ動画などにも応用可能です。

### 製品説明（具体的な製品の説明）
送ったプレゼントにスマートフォンのカメラをかざすとARでキャラクターが出てきてメッセージを話してくれるアプリを開発しました。

### システム構成図
<img src="https://imgur.com/kSb3FVW.png" width="800">

### 特長

#### 1. プレゼントにカメラをかざすとARでキャラクターが表示
GIF動画

#### 2. キャラクターが録音したメッセージを話してくれる
GIF動画

#### 3. キャラクターのモーションを設定可能
GIF動画

### 解決出来ること
単身赴任や、一人暮らしが増えている現在
ARでリアルなメッセージを送ることで心理的な距離を縮める。

* 全体の27%,20~24歳男性の35%が遠距離恋愛中
<img src="https://imgur.com/EJgYO7S.jpg" width="600">
（出典）株式会社オーネット 広報グループ


* 遠距離恋愛で心配なこと１位がコミュニケーション頻度の低下
<img src="https://imgur.com/q9RbTLW.jpg" width="600">
（出典）株式会社オーネット 広報グループ


### 今後の展望
#### 技術的な展望
* Vtuberのように音声に合わせてキャラクターを動かしたり、モーションキャプチャを用いて自由に動きを変える機能の実装
* HoloLensのようなスマートグラスでの実装（店頭での商品説明・販売促進への利用）

#### サービスの応用可能性
* 店頭で製品案内
スマートグラスが普及した後、家電量販店で売っている商品に本機能を適用し、ARで表示したキャラクターや芸能人が紹介してくれる。
* ファンクラブ会員や株主へのメッセージ
企業向けに、会報などにカメラをかざすことでARで芸能人がメッセージを話す機能をつける。
株主へのIR資料に社長からのメッセージ、コンテンツ企業であればキャラクターからの感謝などをつける。


## 開発内容・開発技術
### 活用した技術
#### API・データ
今回スポンサーから提供されたAPI、製品などの外部技術があれば記述をして下さい。

* ミライ小町3Dモデル[バンダイナムコ様](https://www.bandainamco.co.jp/)

#### フレームワーク・ライブラリ・モジュール
* Unity ARkit2.0

#### デバイス
* iPhone

### 研究内容・事前開発プロダクト（任意）
* なし


### 独自開発技術（Hack Dayで開発したもの）
#### 2日間に開発した独自の機能・技術
独自で開発したものの内容をこちらに記載してください
特に力を入れた部分をファイルリンク、またはcommit_idを記載してください（任意）
* ARkitPluginのARObjectScannerとARObjectAnchor，ミライ小町ちゃんモデルを使い特定の物体に対してARモデルを表示する


### メモ・必須記入事項
* titile/summery 一言で言ってどういうサービスか
* problem どういった問題を解決しようとしているか
* solution/demo どういうソリューションを提供するか
* market どれくらい潜在的なマーケットがあるか、今後どのくらいのサイズになりそうか
* unique insight
* business model
* scalability
