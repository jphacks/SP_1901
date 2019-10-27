import os
import requests

res = requests.post(
    'https://labs.goo.ne.jp/api/morph',
    json={
        # 環境変数APP_IDに発行したアプリケーションIDを保存している場合
        'app_id': os.getenv("20e4cfd3b4227473d0e8f171749378cb7a8049fb7dcbaa276ca33e6875ddfa74"),
        'sentence': '日本語を分析します'
    }
)

print(res)
print(res.json())