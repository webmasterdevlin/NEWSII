using NEWSII.Helpers;

var scores = new List<int>();

var respiratoryRate = RespiratoryRate.GetRespiratoryRateInput();
RespiratoryRate.AddRespiratoryRateScore(respiratoryRate, scores);

var heartRate = HeartRate.GetHeartRateInput();
HeartRate.AddHeartRateScore(heartRate, scores);

var bodyTemp = BodyTemp.GetBodyTempInput();
BodyTemp.AddBodyTempScore(bodyTemp, scores);

var totalScores = scores.Sum();

Console.WriteLine("NEWS-II's Score: " + totalScores);
Console.Read();
