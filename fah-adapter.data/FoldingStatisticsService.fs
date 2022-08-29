namespace FahAdapter.Data

open System.Net.Http

type FoldingStatisticsService () =
  member this.GetStatistics() =
    use http = HttpClient()
    let response = http.GetAsync("https://apps.foldingathome.org/daily_user_summary.txt")

    0

