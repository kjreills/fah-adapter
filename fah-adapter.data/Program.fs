namespace FahAdapter.Data

//open FahAdapter.Data

module Program =
  [<EntryPoint>]
  let main args =
    printfn "Hello from F#"
    printfn "Downloading Folding@Home stats..."

    let stats = FoldingStatisticsService()

    0

