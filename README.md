English is below.


# Outline Storming GPT

このツールは、ChatGPTを使用してデータを定義し、整合性をテストし、改良するためのものです。単純に会話することもできますし、ゲームの設定や計算式を読み込んで想定レベルや経験値テーブルを作成することもできます。
Ver2.0で、DeepL APIの呼び出しに対応しました。
自動的に翻訳を挟んでChatGPTと入出力可能です。
コードをなるべくChatGPTに書かせている為、大分統一性がないコードになってきました……

## ライセンス

MIT

## 必要なNugetパッケージ

- Csv2.0.93：https://www.nuget.org/packages/Csv
- Microsoft.AspNetCore.Http.Extensions 2.2.0：https://www.nuget.org/packages/Microsoft.AspNetCore.Http.Extensions
- Microsoft.Extensions.Http 7.0.0：https://www.nuget.org/packages/Microsoft.Extensions.Http/8.0.0-preview.2.23128.3

## 使い方

OpenAIのWebサイトで事前にAuthキー（APIキー）を発行してください。

需要があれば機能を拡張するかもしれません。

フォーマットは、タブ、カンマ、SOHによって区切られたCSVです。SOHはTRALEのデータ管理にも使用されています。

デフォルトのタイムアウトは60秒です。Chat GPTの現在の混雑状況を考慮して、180秒程度に延長することも良いかもしれません（GUI上で変更可能）。大きなデータセットを送信するとクラッシュする可能性があるため注意してください。

# Outline Storming GPT

This is a tool for defining data and testing consistency by using ChatGPT and improving it. It is possible to simply have a conversation, or to load game settings and formulas to create expected level and experience tables. 
Ver. 2.0 supports calls to DeepL API.
It is possible to input/output with ChatGPT while translating.
The code is becoming much less consistent because we are having ChatGPT write as much of the code as possible: ......

## License 

MIT 

## Required Nuget Packages 

- Csv2.0.93: https://www.nuget.org/packages/Csv 
- Microsoft.AspNetCore.Http.Extensions 2.2.0: https://www.nuget.org/packages/Microsoft.AspNetCore.Http.Extensions
- Microsoft.Extensions.Http 7.0.0: https://www.nuget.org/packages/Microsoft.Extensions.Http/8.0.0-preview.2.23128.3 

## Usage 

Please issue an Auth key (API key) in advance at OpenAI's website. 

If there is demand, it may be expanded. 

The format is csv separated by Tab, Comma, and SOH. SOH is also used for data management in TRALE. 

The default timeout is 60 seconds. Considering the current congestion situation of Chat GPT, it may be worth extending it to around 180 seconds (which can be changed on the GUI). Sending too large a dataset may result in a crash.
