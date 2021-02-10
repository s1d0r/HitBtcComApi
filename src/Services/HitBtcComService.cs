namespace s1d0r.HitBtcComAPI.Services
{
    public class HitBtcComService
    {
        public HitBtcCom HitBtcComApi { get; set; }
        public HitBtcComService(string publicKey, string privateKey)
        {
            HitBtcComApi = new HitBtcCom(publicKey, privateKey);
        }
    }
}