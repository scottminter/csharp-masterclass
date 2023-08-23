
using System.Text.RegularExpressions;

var log1 = "Apr 10 11:17:35 coderbyte heroku/router: at=info method=GET path=\"/backend/requests/editor/placeholder?shareLinkId=tosrve4v8q8q\" host=coderbyte.com request_id=097bf65e-e189-4f9f-9dfb-4758cff411b2 fwd=\"108.31.000.000\" dyno=web.3 connect=1ms service=10ms status=200 bytes=4435 protocol=https";
Console.WriteLine(log1);

//int startI = log1.IndexOf("?shareLinkId=");
//int endI = log1.Substring(startI, log1.IndexOf("\"") - startI);

//var match = Regex.Match(log1, @"shareLinkId=(.+?)\""").Groups[1].Value;
//Console.WriteLine(match);

var match = log1.Split(new string[] { "shareLinkId=" }, StringSplitOptions.None)[1]
    .Split("\"")[0]
    .Trim();

Console.WriteLine(match);

Console.Read();

