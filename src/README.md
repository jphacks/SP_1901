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
全てUnity中で使用したスクリプト。

## AddScene.cs
ミライ小町のモーションを追加する画面から
AR・音声の動作確認のシーンへ遷移するためのスクリプト。

## AddSceneStart.cs
ミライ小町のモーションを追加する画面から
AR・音声の動作確認のシーンへ遷移するためのスクリプト。

## Bto1ButtonScript.cs
ホーム画面へ遷移するためのスクリプト。

## Bto2ButtonScript.cs
ユーザーにアプリ中での操作の流れを伝えるシーンへ遷移するためのスクリプト。

## Bto6ButtonScript.cs
AR・音声の動作確認のシーンへ遷移するためのスクリプト。

## ButtonScript.cs
ミライ小町のUnityプロジェクトからAnimatorコンポーネントを取得するためのスクリプト。

## ButtonScript1.cs
ミライ小町のUnityプロジェクトからAnimatorコンポーネントを取得するためのスクリプト。

## Fto2ButtonScript.cs
スタート画面へ遷移するためのスクリプト。

## Fto3ButtonScript.cs
送りたいプレゼントの確認画面へ遷移するためのスクリプト。

## Fto4ButtonScript.cs
音声を録音・再生する画面へ遷移するためのスクリプト。

## Fto5ButtonScript.cs
ミライ小町のモーションを追加する画面へ遷移するためのスクリプト。

## Fto7ButtonScript.cs
AR・音声の送信完了画面へ遷移するためのスクリプト。

## KeepStr.cs
ミライ小町のモーションを選択する際、選んだモーションをに応じたStringを取得し保持するためのスクリプト。

## KomachiFaceAnimation.cs
ミライ小町の表情を指定するスクリプト。

## RecordController.cs
ボタンを操作し音声の録音・再生を行うためのスクリプト。

