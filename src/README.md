# 各ディレクトリの説明

## GitTest
チームのGithub練習用。

## MiraikomachiUnity-master
ミライ小町のUnityプロジェクト。

## Scandata
ARKit Scannerであらかじめスキャンした3Dモデルデータを保存している。
企業のPOSシステム等とのコラボレーションにより、
商品の3Dオブジェクトのスキャンデータを一括管理可能なプラットフォームを構築することを目指している。

## ScanningAndDetecting3DObjects
ARKit Scanner。スマホのカメラで3Dオブジェクトをスキャンするプロジェクト。
Swiftで書かれている。

## goo_api
形態素解析に使用している。
GoogleCloudを用いて録音した音声を文字認識し、gooラボAPIを用いて形態素解析を行う。
音声に含まれる言葉に合わせて、ミライ小町のモーションを自動で選択追加することを目指している。
なお、形態素解析までは実装済み。

## Unity-iPhone.xcodeproj
UnityをiOS向けにビルドしたXCodeプロジェクト。

# 各スクリプトの説明

## AddScene.cs
Unity中でモーション追加の画面から
ARの動作確認のシーンへの遷移するためのスクリプト。

## AddSceneStart.cs
Unity中でモーション追加の画面から
AR・音声の動作確認のシーンへ遷移するためのスクリプト。

## Bto1ButtonScript.cs
Unity中でホーム画面へ遷移するためのスクリプト。

## Bto2ButtonScript.cs
Unity中でユーザーにアプリ中での操作の流れを伝えるシーンへ遷移するためのスクリプト。

## Bto6ButtonScript.cs
Unity中でAR・音声の動作確認のシーンへ遷移するためのスクリプト。

## ButtonScript.cs
Unity中でミライ小町のAnimatorコンポーネントを取得するためのスクリプト。

## ButtonScript1.cs
Unity中でミライ小町のAnimatorコンポーネントを取得するためのスクリプト。

## Fto2ButtonScript.cs
Unity中でスタート画面へ遷移するためのスクリプト。

## Fto3ButtonScript.cs
Unity中でプレゼントの確認画面へ遷移するためのスクリプト。

## Fto4ButtonScript.cs
Unity中で音声メッセージを録音・再生する画面へ遷移するためのスクリプト。

## Fto5ButtonScript.cs
Unity中でミライ小町のモーションを追加する画面へ遷移するためのスクリプト。

## Fto7ButtonScript.cs
Unity中で送信完了画面へ遷移するためのスクリプト。

## KeepStr.cs
Unity中でモーション選択をする際、選んだモーションを著すStringを取得し、保持するためのスクリプト。

## KomachiFaceAnimation.cs
Unity中でのミライ小町の表情を指定するスクリプト。

## RecordController.cs
Unity中でボタンを操作し音声の録音・再生を行うためのスクリプト。

