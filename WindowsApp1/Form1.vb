Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Form1
    Private names = {"马文栋",
"马纯逸",
"马展熠",
"王子恒",
"王文权",
"王晨希",
"叶至行",
"史依尔",
"邢秩锟",
"许一鸣",
"杨凯然",
"吴霄峰",
"吴鑫杰",
"邱子安",
"沈致远",
"宋宇宸",
"宋轶凡",
"宋琛祺",
"张丹雯",
"张波",
"张砺寒",
"张路遥",
"张鑫晨",
"金梦媛",
"周宇成",
"周希杰",
"郑泓楠",
"单凯歆",
"赵恒杰",
"娄泽霖",
"姚佳莉",
"袁午田",
"袁金凯",
"徐启涵",
"唐诗格",
"唐诗梦",
"唐斌",
"陶扬元",
"章剑豪",
"章强强",
"谢科烨",
"楼志宇",
"裘昊晔",
"裘海怡",
"裘遒",
"樊咏琦",
"魏楚珊",
"沈伊宁",
"钱奕含",
"李嘉能"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim textContent As String = "D:\1.csv"
        Dim sw As New StreamWriter(textContent, False, Encoding.Unicode)
        For Each i In names

            sw.Write(i)
            sw.Write(Chr(9))
            Dim t = GetKeyValue(i, "物理", "", inipath)
            sw.Write(t)
            sw.Write(Chr(9))
            t = GetKeyValue(i, "化学", "", inipath)
            sw.Write(t)
            sw.Write(Chr(9))
            t = GetKeyValue(i, "生物", "", inipath)
            sw.Write(t)
            sw.Write(Chr(9))
            t = GetKeyValue(i, "政治", "", inipath)
            sw.Write(t)
            sw.Write(Chr(9))
            t = GetKeyValue(i, "历史", "", inipath)
            sw.Write(t)
            sw.Write(Chr(9))
            t = GetKeyValue(i, "地理", "", inipath)
            sw.Write(t)
            sw.Write(Chr(9))
            t = GetKeyValue(i, "技术", "", inipath)
            sw.Write(t)
            sw.Write(Chr(9))
            t = GetKeyValue(i, "英语", "", inipath)
            sw.Write(t)
            sw.Write(Chr(9))
            sw.WriteLine()
        Next
        sw.Close()
    End Sub


End Class
