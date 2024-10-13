给您一个由n位数字制成的字符串，代表一个正整数。

在所有比s小的正整数中，找到最大数字总和。

写一个函数：

类解决方案{公共字符串解决方案（字符串S）;}

that, given a string S, returns a string representing a positive integer smaller than S with themaximum possible sum of digits. lf there is more than one such integer, return any of them. 
Thereturned string can only consist of digits and may not contain leading zeros.

给定一个字符串s，返回一个代表高于s的正整数的字符串，最大的数字总和。如果有一个以上的整数，请退还其中任何一个。返回的字符串只能由数字组成，并且可能不包含领先的零。

示例：

1。给定s =“ 899”，可能的正确答案之一是“ 898”。

2。给定s =“ 10”，唯一可能的正确答案是“ 9”。

3。给定s =“ 98”，唯一可能的正确答案是“ 89”。

为以下假设编写有效的算法：

n是[2..100,000]范围内的整数；

字符串S仅由数字（0-9）制成；

S不包含领先的零。