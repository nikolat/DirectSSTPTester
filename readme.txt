========================================================================
【ソフト名称】DirectSSTPTester
【 制 作 者 】Don
【 動作環境 】Windows10 21H2 + .NET 6.0
【 タ イ プ 】DirectSSTP送信テストツール
【 取扱種別 】フリーウェア
【 配布月日 】2021/06/08
【 配 布 元 】http://nikolat.herokuapp.com/
【  備  考  】後述
========================================================================
■概要

  DirectSSTPを送信するシンプルなテストツールです。
  ゴーストのデバッグというよりもSSTPの送受信自体をテストすることを目的としており、
  受信したレスポンスも表示します。

■機能

  起動時にdefault.txtを取り込みます。
  よく使う送信内容を登録しておくと便利です。
  同梱したsample*.txtも送信テキストエリアにドラッグ＆ドロップすることで
  取り込むことができます。

■ライセンス

  ukiya氏のSSTPLibを一部改変して利用しております。
  ありがとうございます。

    SSTPLib
      http://ukiya.sakura.ne.jp/index.php?%E4%BC%BA%E3%81%8B%E9%96%A2%E9%80%A3%E3%83%84%E3%83%BC%E3%83%AB%2FSSTPLib

  上記以外のコードのライセンスは「CC0 1.0 Universal」です。

    Creative Commons - CC0 1.0 Universal
      http://creativecommons.org/publicdomain/zero/1.0/

■更新履歴
2022/03/08  Ver1.3.0  ・ゴースト名取得時にSakuraUnicode FMOを使用
2022/03/02  Ver1.2.0  ・SSTPプロトコル違反の修正、Shift_JIS以外の文字コード対応
2021/11/13  Ver1.1.0  ・ターゲットフレームワークを.NET 6.0に変更
2021/06/08  Ver1.0.0  ・新規作成
