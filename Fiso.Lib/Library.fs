namespace Fiso.Lib

type MyDu =
    | CaseA
    | CaseB

type Abc =
    | Cdf
    | Hql

module PrintStuff =
    let printOther() =
        printfn "I'm private! %A %A" Cdf Hql
    
    let printMyDu (du: MyDu) =
        printfn "%A" du
        printOther()
