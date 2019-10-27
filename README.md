# GIFT ARrow

[![Product Name](image.png)](https://www.youtube.com/watch?v=G5rULR53uMk)

## 製品概要
### プレゼント×Tech（AR）

### 背景（製品開発のきっかけ、課題等）
#### 遠距離恋愛の課題をプレゼントで解決する！

私たちは単身赴任で遠く離れた家族や、遠距離恋愛のカップルの抱えている「もっと心理的な障壁を無くしたい」という思いを解決したいと思い、本プロダクトを開発しました。

本プロダクトでは、様々なプレゼントにARを表示させる機能をつけ、自分の送りたいメッセージをキャラクターに話してもらうことができるサービスを提供します。

ファン向けのメッセージ動画などにも応用可能です。

#### 商品名の由来
AR映像を遠くにいるプレゼントの受取り手に届けるという意味で、"矢"という意味のある"arrow"を用いました。
AR動画とプレゼントを載せた矢が受取り手に届くというイメージです。

### 製品説明（具体的な製品の説明）
送ったプレゼントにスマートフォンのカメラをかざすとARでキャラクターが出てきてメッセージを話してくれるアプリを開発しました。詳しくは下記システム構成図を参照ください。

### システム構成図
<img src="https://imgur.com/NEn2buM.png" width="800">

### 特長

#### 1. プレゼントにカメラをかざすとARでキャラクターが表示
GIF動画

#### 2. キャラクターが録音したメッセージを話してくれる
GIF動画

#### 3. キャラクターのモーションを設定可能
GIF動画

### 解決出来ること
単身赴任や、一人暮らしが増えている現在
AR＋音声で親近感の持てるメッセージを送ることで心理的な距離を縮める。

* 全体の27%,20~24歳男性の35%が遠距離恋愛中
<img src="https://imgur.com/EJgYO7S.jpg" width="600">
（出典）株式会社オーネット 広報グループ


* 遠距離恋愛で心配なこと１位がコミュニケーション頻度の低下
<img src="https://imgur.com/q9RbTLW.jpg" width="600">
（出典）株式会社オーネット 広報グループ

### 今後の展望
#### 技術的な展望
* gooラボAPIを用いて、録音した音声に合わせたモーションを自動で追加
* 深層学習の活用による，認識の精度向上および認識可能オブジェクト数の増加による汎用性の向上
* 表示される3Dモデル数の充足化による多様なメッセージ表現の実現
* 「Face Tracking」や「Bone tracking」等の高度なヒトの認識技術の活用により、送り主の表情や動作がトレースされたよりリアルな3Dモデルの実装
* Holorens等のAR・MRデバイスへの実装による広い普及や利便性の向上（店頭での商品説明・販売促進などへの利用）
* POSシステム等とのコラボレーションによる、商品の3Dオブジェクトのスキャンデータを一括管理可能なプラットフォーム構築

#### サービスの応用可能性
* 店頭での製品案内
家電量販店で売っている商品に本機能を適用し、ARで表示したキャラクターや芸能人が紹介してくれる。
スマートグラスが普及した後、より良い体験が期待できる。
* ファンクラブ会員や株主へのメッセージ
今回はCtoCのサービスとして開発したが、
企業向けに、会報などに本機能を付け、ARで芸能人がメッセージを話す機能をつける。
株主へのIR資料に社長からのメッセージ、コンテンツ企業であればキャラクターからのメッセージなどをつける。


## 開発内容・開発技術
### 活用した技術
#### API・データ
今回スポンサーから提供されたAPI、製品などの外部技術があれば記述をして下さい。

* [ミライ小町3Dモデル](https://github.com/Miraikomachi)（[バンダイナムコ](https://www.bandainamco.co.jp/)様）
* [gooラボAPI](https://labs.goo.ne.jp/)様（[NTTレゾナント](https://www.nttr.co.jp/)様）

#### フレームワーク・ライブラリ・モジュール
* Unity ARkit2.0（ARの表示、物体の特徴点のマッチングなど）

#### デバイス
* iOS（実機）

### 研究内容・事前開発プロダクト（任意）
* なし


### 独自開発技術（Hack Dayで開発したもの）
#### 2日間に開発した独自の機能・技術
独自で開発したものの内容をこちらに記載してください
特に力を入れた部分をファイルリンク、またはcommit_idを記載してください（任意）
* 送り主のメッセージ録音システム
UnityのMicrophone Classを使用し、表示するARオブジェクトに合わせて再生するメッセージを録音する機能を開発した。
* 使用者の好みに応じたミライ小町の表情変化システム
ミライ小町ちゃんの表情をVRMを用いて独自に表情を変化させるシステムの構築。また、外部のモーションデータをミライ小町ちゃんに適用することで、表情とメッセージ音声にリンクした動作を実現。
* 3Dオブジェクトのスキャンデータ生成
ARkit2.0のARKitScannerを応用することで、送り主や商品販売者が商品の3Dオブジェクトを簡便かつ高精度ににスキャン可能なアプリケーションを作成。これにより、マーカーレスARによる情報提示が実現可能となる。
* ARkitPluginのARObjectScannerとARObjectAnchor，ミライ小町ちゃんモデルを使い特定の物体に対してARモデルを表示する


### メモ・必須記入事項
* titile/summery 一言で言ってどういうサービスか
* problem どういった問題を解決しようとしているか
* solution/demo どういうソリューションを提供するか
* market どれくらい潜在的なマーケットがあるか、今後どのくらいのサイズになりそうか
* unique insight
* business model
* scalability
