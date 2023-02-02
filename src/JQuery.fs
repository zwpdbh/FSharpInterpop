namespace FableDemo

open Fable.Core
open System

type IJQuery =
    abstract css: string * string -> IJQuery
    abstract addClass: string -> IJQuery

    [<Emit("$0.click($1)")>]
    abstract onClick: (obj -> unit) -> IJQuery


type AddTimeProps =
    abstract current: DateTime with get, set
    abstract amount: int with get, set
    abstract unit: string with get, set

module JQueryV1 =

    //type IJQuery = interface end

    //[<Emit("window['$']($0)")>]
    [<Emit("window.$($0)")>]
    let select (selector: string) : IJQuery = jsNative

    [<Emit("$2.css($0, $1)")>]
    let css (prop: string) (value: string) (el: IJQuery) : IJQuery = jsNative

    [<Emit("$1.addClass($0)")>]
    let addClass (className: string) (el: IJQuery) : IJQuery = jsNative

    [<Emit("$1.click($0)")>]
    let click (handler: obj -> unit) (el: IJQuery) : IJQuery = jsNative


module JQueryV2 =

    //type IJQuery = interface end

    //[<Emit("window['$']($0)")>]
    [<Emit("window.$($0)")>]
    let select (selector: string) : IJQuery = jsNative

    [<Emit("$2.css($0, $1)")>]
    let css (prop: string) (value: string) (el: IJQuery) : IJQuery = jsNative

    [<Emit("$1.addClass($0)")>]
    let addClass (className: string) (el: IJQuery) : IJQuery = jsNative

    [<Emit("$1.click($0)")>]
    let onClick (handler: obj -> unit) (el: IJQuery) : IJQuery = jsNative


module ObjectLiterals = 
    // TBD: Working with object literals
    let demo () = 
        0