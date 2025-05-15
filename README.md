# Azure AI Search サンプル（AI-102 ラボ11）

- ラボ11を起動（以下の手順はラボ内で実施）
- Azure portalで「Azure AI Search」リソースを作成
  - リソースグループは作成済みのものを使用
  - 価格レベルはFreeを選択
- Azure portal でストレージアカウントを作成
  - Blobコンテナーを作成
    - `employee-data.json`をアップロード
- Azure AI Search でインデックスを作成
- 環境変数 SEARCH_ENDPOINT を作成。値: リソースのエンドポイント(概要画面のURL)
- 環境変数 SEARCH_KEY を作成。値: リソースのキー
- 環境変数 SEARCH_INDEX を作成。値: インデックスの名前
- Visual Studio Codeを起動（以下の手順はVisual Studio Code内で実施）
- 本リポジトリをクローン
- ターミナルを起動し、dotnet run でプログラムを実行
