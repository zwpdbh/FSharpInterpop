module App

open Fable.Core
open Fable.Core.JsInterop

open FableDemo

//Now, take a closer look at the function isUndefined . It has one paramter called x of a generic type 'a . The function returns bool . Then notice that $0 in the emit expression , that is a placeholder of whatever value you pass to the function in the place of parameter x . It has the number 0 because the parameters are 0-indexed and therefore the first parameter (in this case x ) will have the index 0.

[<Emit("$0 === undefined")>]
let isUndefined (x: 'a) : bool = jsNative

[<Emit("undefined")>]
let undefined: obj = jsNative

printfn $"Fable is up and running 2222 {undefined}"

[<Emit("isNaN(parseFloat($0)) ? null : parseFloat($0)  ")>]
let parseFloat (input: string) : float option = jsNative


match parseFloat "5.3" with
| Some value -> printfn $"{value}"
| None -> printfn $"no value"


JQueryV1
    .select("#demo01")
    .css("background-color", "lightblue")
    .css("font-size", "24px")
    .onClick(fun ev -> printfn "demo01 clicked")
    .addClass ("fancy-class")
|> ignore

JQueryV2.select "#demo02"
|> JQueryV2.css "background-color" "red"
|> JQueryV2.css "font-size" "24px"
|> JQueryV2.onClick (fun ev -> printfn("demo02 clicked"))
|> JQueryV2.addClass "fancy-class"
|> ignore
