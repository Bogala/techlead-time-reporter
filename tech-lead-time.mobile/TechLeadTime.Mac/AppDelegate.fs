﻿namespace TechLeadTime.Mac
open System
open Foundation
open AppKit

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit NSApplicationDelegate ()
