## 本项目可以将汉字转换为拼音。本项目使用.NET Core实现

### 汉字转拼音
```
var text = PinYin.GetPinYin("测试文字", PinYinType.拼音);
//text结果为 ce shi wen zi
```

### 汉字转拼音(拼音首字母)
```
var text = PinYin.GetPinYin("测试文字", PinYinType.拼音首字母);
//text结果为 CSWZ
```
