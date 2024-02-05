Option Strict On
Option Explicit On

Module FortuneCookie

    Sub Main()
        Dim wisdoms As New List(Of String)

        wisdoms.Add("Marriage lets you annoy one special person for the rest of your life.")
        wisdoms.Add("Lucky is coming your way!")
        wisdoms.Add("Your life is what your thoughts make it.")
        wisdoms.Add("You will live to eat many fortune cookies.")
        wisdoms.Add("Happiness lies in the joy of achievement and the thrill of creative effort.")
        wisdoms.Add("Curiosity kills boredom. Nothing can kill curiosity.")
        wisdoms.Add("Keep up the good work. You will be rewarded.")
        wisdoms.Add("Never fear shadows. They simply mean there's a light shining somewhere nearby.")
        wisdoms.Add("If you don't fail now and again, it's a sign that you're playing it safe.")
        wisdoms.Add("Help! I'm being held prisoner in a Chinese bakery!")

        Static random As New Random()
        Dim randomWisdom = wisdoms(random.Next(wisdoms.Count))
        Console.WriteLine(randomWisdom)

        Console.Read()

    End Sub

End Module
