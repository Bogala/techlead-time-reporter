namespace TechLeadTime

open Xamarin.Forms
open Xamarin.Forms.Xaml

type TechLeadTimePage() =
    inherit ContentPage()
    let _ = base.LoadFromXaml(typeof<TechLeadTimePage>)
