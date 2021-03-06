﻿Module Program

    Sub Main()
        Dim mBoxStyle = MsgBoxStyle.RetryCancel
        Dim enumValues = [Enum].GetValues(GetType(MsgBoxStyle)).Cast(Of MsgBoxStyle).ToArray
        Dim timer As New Stopwatch
        Const LoopCount = 10_000_000
        Console.WriteLine($"Loop count:={LoopCount.ToString("#,#")}, Enum type:={GetType(MsgBoxStyle)}, Enum values count:={enumValues.Length}")
        timer.Start()
        LongEnumGetValues(mBoxStyle, enumValues, LoopCount)
        timer.Stop()
        Console.WriteLine($"Enum constraint and embedded IL has flag: {timer.ElapsedMilliseconds}ms.")
        timer.Restart()
        Net461EnumGetValues(mBoxStyle, enumValues, LoopCount)
        timer.Stop()
        Console.WriteLine($"Net461 has flag: {timer.ElapsedMilliseconds}ms.")
        Console.WriteLine("Done.")
    End Sub

    Private Sub Net461EnumGetValues(mBoxStyle As MsgBoxStyle, enumValues() As MsgBoxStyle, loopCount As Integer)
        For i = 1 To loopCount
            For j = 0 To enumValues.Length - 1
                Dim hasFlg = mBoxStyle.HasFlag(enumValues(j))
            Next
        Next
    End Sub

    Private Sub LongEnumGetValues(mBoxStyle As MsgBoxStyle, enumValues() As MsgBoxStyle, loopCount As Integer)
        For i = 1 To loopCount
            For j = 0 To enumValues.Length - 1
                Dim hasFlg = EnumHelper.HasFlag(mBoxStyle, enumValues(j))
            Next
        Next
    End Sub
End Module
