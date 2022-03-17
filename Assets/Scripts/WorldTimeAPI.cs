using UnityEngine;
public class WorldTimeAPI : SingletonMonoBehaviour<WorldTimeAPI>
{
    // Fields
    private const string API_URL = "http://worldtimeapi.org/api/ip";
    public bool IsTimeLoaded;
    private System.DateTime _currentDateTime;
    private UnityEngine.WaitForSecondsRealtime time;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Screen.sleepTimeout = 0;
    }
    private void Start()
    {
        System.Collections.IEnumerator val_1 = this.GetRealDateTimeFromAPI();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  587427728);
    }
    public System.DateTime GetCurrentDateTime()
    {
        WorldTimeAPI val_5;
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        var val_2 = R1 + 16;
        System.DateTime val_3 = AddSeconds(value:  null);
        this = val_5;
        return new System.DateTime() {dateData = val_5};
    }
    private System.Collections.IEnumerator GetRealDateTimeFromAPI()
    {
        536902523 = new WorldTimeAPI.<GetRealDateTimeFromAPI>d__7(<>1__state:  0);
        mem[536902539] = this;
    }
    private System.DateTime ParseDateTime(string datetime)
    {
        System.Text.RegularExpressions.Match val_1 = System.Text.RegularExpressions.Regex.Match(input:  R2, pattern:  -1610602181);
        string val_2 = R2.Value;
        System.Text.RegularExpressions.Match val_3 = System.Text.RegularExpressions.Regex.Match(input:  R2, pattern:  -1610602253);
        string val_4 = R2.Value;
        string val_5 = System.String.Format(format:  -1610597027, arg0:  R2, arg1:  R2);
        System.DateTime val_6 = System.DateTime.Parse(s:  587755792);
        this = null;
        return new System.DateTime();
    }
    public WorldTimeAPI()
    {
        System.DateTime val_1 = System.DateTime.Now;
        this._currentDateTime = new System.DateTime();
        UnityEngine.WaitForSecondsRealtime val_2 = 536896855;
        val_2 = new UnityEngine.WaitForSecondsRealtime(time:  null);
        this.time = val_2;
    }

}
