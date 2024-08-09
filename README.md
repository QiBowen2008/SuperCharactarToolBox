# 万能文字工具箱——免费的文字处理助手

**提示：Word插件上新了**

本款软件基于Github上各种开源库制作而成（几乎没有什么代码研究价值），免费实现各种文字处理功能。包括OCR识别、文字转语音、词云生成、文字转拼音、翻译、分词等功能（除了翻译功能均可以离线使用）欢迎下载体验。
![输入图片说明](https://github.com/QiBowen2008/SuperTextToolBox/blob/OldBranch/Pics/1.PNG?raw=true)

## 1、OCR识别（64bit）

基于[PaddleOCRSharp](https://gitee.com/raoyutian/paddle-ocrsharp)开发，拥有很高的精确度（即使是位置杂乱无章的文本）。下图为示范图
![OCR识别效果](https://github.com/QiBowen2008/SuperTextToolBox/blob/OldBranch/Pics/6.PNG?raw=true)

## 2、文字转语音

基于微软自己的System.Speech库实现，支持较多语言，同时破处了某办公软件非会员不能导出的限制。
![输入图片说明](https://github.com/QiBowen2008/SuperTextToolBox/blob/OldBranch/Pics/4.PNG?raw=true)

## 3、词云生成

基于[WordCloudSharp](https://github.com/AmmRage/WordCloudSharp)实现，可以选择模版（目前暂时不能完全自定义）
![输入图片说明](https://github.com/QiBowen2008/SuperTextToolBox/blob/OldBranch/Pics/7.PNG?raw=true)
## 4、文字转拼音

基于[Chinese](https://github.com/zmjack/Chinese)库实现，无限制文字转拼音（解除了某办公软件非会员30个字的限制）
![输入图片说明](https://github.com/QiBowen2008/SuperTextToolBox/blob/OldBranch/Pics/3.PNG?raw=true)

## 5、翻译（在线）

基于百度翻译，支持上百种语言，未来还可以进行指定领域翻译
![输入图片说明](https://github.com/QiBowen2008/SuperTextToolBox/blob/OldBranch/Pics/2.PNG?raw=true)

## 6、分词

类似Jieba的分词功能
![输入图片说明](https://github.com/QiBowen2008/SuperTextToolBox/blob/OldBranch/Pics/5.PNG?raw=true)

## **7、Word插件（新）**

在word中直接提供以上全部功能！同时附加了一些批量功能，自己体验！

## 附加功能：成语接龙小游戏

仔细玩一下你会发现没什么意思，不会成语一样玩。（正在修复这个Bug）
![输入图片说明](https://github.com/QiBowen2008/SuperTextToolBox/blob/OldBranch/Pics/8.PNG?raw=true)
## 未来计划
1.计划OCR增加截图识别
2.翻译计划增加领域翻译（已经实现）
3.自定义词云生成
4.修复成语接龙Bug
5.增加~~Word和~~PowerPoint插件功能（word实现了）

## 编译注意
这是4个工程，除去开发中的powerpoint插件，你需要把四个工程的输出文件放到一个文件夹里，然后才能使用，还需要把OCR工程里的OCRModel了完全复制到文件夹里，还要把根目录的resource文件复制过去
