# 文本识别模型

## 下载说明
1.只下载推理模型，别下配置文件
2.把文件下载后，解压到软件安装目录的/OCRModel/REC文件夹中

<a name="中文识别模型"></a>

### 1 中文识别模型

|模型名称|模型简介|推理模型大小|下载地址|
| --- | --- | --- |--- |
|ch_PP-OCRv4_rec（自带，对应中英文精简）|【最新】超轻量模型，支持中英文、数字识别| 10M |[推理模型](https://paddleocr.bj.bcebos.com/PP-OCRv4/chinese/ch_PP-OCRv4_rec_infer.tar) / [](https://paddleocr.bj.bcebos.com/PP-OCRv4/chinese/ch_PP-OCRv4_rec_train.tar) |
|ch_PP-OCRv4_server_rec（只要磁盘不紧张我推荐下这个，对应中英文高级）|【最新】高精度模型，支持中英文、数字识别| 88M |[推理模型](https://paddleocr.bj.bcebos.com/PP-OCRv4/chinese/ch_PP-OCRv4_rec_server_infer.tar) / [](https://paddleocr.bj.bcebos.com/PP-OCRv4/chinese/ch_PP-OCRv4_rec_server_train.tar) |





<a name="多语言识别模型"></a>
### 2 多语言识别模型（更多语言持续更新中...，根据需求下载）

|模型名称|字典文件|模型简介|配置文件|推理模型大小|下载地址|
| --- | --- | --- | --- |--- | --- |
| korean_PP-OCRv3_rec | ppocr/utils/dict/korean_dict.txt |韩文识别|[korean_PP-OCRv3_rec.yml](../../configs/rec/PP-OCRv3/multi_language/korean_PP-OCRv3_rec.yml)|11.0M|[推理模型](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/korean_PP-OCRv3_rec_infer.tar) / [](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/korean_PP-OCRv3_rec_train.tar) |
| japan_PP-OCRv3_rec | ppocr/utils/dict/japan_dict.txt |日文识别|[japan_PP-OCRv3_rec.yml](../../configs/rec/PP-OCRv3/multi_language/japan_PP-OCRv3_rec.yml)|11.0M|[推理模型](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/japan_PP-OCRv3_rec_infer.tar) / [](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/japan_PP-OCRv3_rec_train.tar) |
| chinese_cht_PP-OCRv3_rec | ppocr/utils/dict/chinese_cht_dict.txt | 中文繁体识别|[chinese_cht_PP-OCRv3_rec.yml](../../configs/rec/PP-OCRv3/multi_language/chinese_cht_PP-OCRv3_rec.yml)|12.0M|[推理模型](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/chinese_cht_PP-OCRv3_rec_infer.tar) / [](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/chinese_cht_PP-OCRv3_rec_train.tar) |
| te_PP-OCRv3_rec | ppocr/utils/dict/te_dict.txt | 泰卢固文识别|[te_PP-OCRv3_rec.yml](../../configs/rec/PP-OCRv3/multi_language/te_PP-OCRv3_rec.yml)|9.6M|[推理模型](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/te_PP-OCRv3_rec_infer.tar) / [](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/te_PP-OCRv3_rec_train.tar) |
| ka_PP-OCRv3_rec | ppocr/utils/dict/ka_dict.txt |卡纳达文识别|[ka_PP-OCRv3_rec.yml](../../configs/rec/PP-OCRv3/multi_language/ka_PP-OCRv3_rec.yml)|9.9M|[推理模型](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/ka_PP-OCRv3_rec_infer.tar) / [](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/ka_PP-OCRv3_rec_train.tar) |
| ta_PP-OCRv3_rec | ppocr/utils/dict/ta_dict.txt |泰米尔文识别|[ta_PP-OCRv3_rec.yml](../../configs/rec/PP-OCRv3/multi_language/ta_PP-OCRv3_rec.yml)|9.6M|[推理模型](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/ta_PP-OCRv3_rec_infer.tar) / [](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/ta_PP-OCRv3_rec_train.tar) |
| latin_PP-OCRv3_rec |  ppocr/utils/dict/latin_dict.txt | 拉丁文识别 |  [latin_PP-OCRv3_rec.yml](../../configs/rec/PP-OCRv3/multi_language/latin_PP-OCRv3_rec.yml) |9.7M|[推理模型](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/latin_PP-OCRv3_rec_infer.tar) / [](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/latin_PP-OCRv3_rec_train.tar) |
| arabic_PP-OCRv3_rec | ppocr/utils/dict/arabic_dict.txt | 阿拉伯字母 | [arabic_PP-OCRv3_rec.yml](../../configs/rec/PP-OCRv3/multi_language/arabic_PP-OCRv3_rec.yml) |9.6M|[推理模型](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/arabic_PP-OCRv3_rec_infer.tar) / [](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/arabic_PP-OCRv3_rec_train.tar) |
| cyrillic_PP-OCRv3_rec | ppocr/utils/dict/cyrillic_dict.txt | 斯拉夫字母 | [cyrillic_PP-OCRv3_rec.yml](../../configs/rec/PP-OCRv3/multi_language/cyrillic_PP-OCRv3_rec.yml) |9.6M|[推理模型](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/cyrillic_PP-OCRv3_rec_infer.tar) / [](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/cyrillic_PP-OCRv3_rec_train.tar) |
| devanagari_PP-OCRv3_rec | ppocr/utils/dict/devanagari_dict.txt |梵文字母 | [devanagari_PP-OCRv3_rec.yml](../../configs/rec/PP-OCRv3/multi_language/devanagari_PP-OCRv3_rec.yml) |9.9M|[推理模型](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/devanagari_PP-OCRv3_rec_infer.tar) / [](https://paddleocr.bj.bcebos.com/PP-OCRv3/multilingual/devanagari_PP-OCRv3_rec_train.tar) |
