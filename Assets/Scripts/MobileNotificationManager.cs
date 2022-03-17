using UnityEngine;
public class MobileNotificationManager : MonoBehaviour
{
    // Fields
    private string[] notificationTitles;
    private string[] notificationMessages;
    private NotificationIconType iconType;
    
    // Methods
    private void Start()
    {
        var val_6;
        var val_7;
        var val_8;
        object val_9;
        AndroidNotificationCenter.NotificationReceivedCallback val_10;
        Unity.Notifications.Android.AndroidNotificationCenter.CancelAllNotifications();
        Unity.Notifications.Android.AndroidNotificationCenter.RegisterNotificationChannel(channel:  new Unity.Notifications.Android.AndroidNotificationChannel() {<Id>k__BackingField = -1610599263, <Name>k__BackingField = -1610599261, <Description>k__BackingField = -1610607933, <Importance>k__BackingField = 3, <CanBypassDnd>k__BackingField = ???, <CanShowBadge>k__BackingField = ???, <EnableLights>k__BackingField = ???, <EnableVibration>k__BackingField = ???});
        if(this.notificationTitles != null)
        {
                val_6 = this.notificationTitles;
            val_7 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  -1610599261);
        }
        else
        {
                val_6 = 12;
            val_7 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  0);
        }
        
        this.iconType.PushNotification_Span(title:  this.notificationTitles[val_7], text:  this.notificationMessages[UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  0)], time:  720, timeSpan:  null, iconType:  1103101952);
        val_8 = 536900015;
        if(((mem[536900202] & true) == 0) && (mem[536900131] == 0))
        {
                val_8 = 536900015;
        }
        
        val_9 = mem[536900107];
        val_10 = mem[mem[536900107] + 4];
        val_10 = mem[536900107] + 4;
        if(val_10 == 0)
        {
                if(((mem[536900202] & true) == 0) && (mem[536900131] == 0))
        {
                val_9 = mem[536900107];
        }
        
            val_10 = 536897887;
            val_10 = new AndroidNotificationCenter.NotificationReceivedCallback(object:  val_9, method:  new IntPtr(1610677091));
            mem2[0] = val_10;
        }
        
        Unity.Notifications.Android.AndroidNotificationIntentData val_5 = Unity.Notifications.Android.AndroidNotificationCenter.GetLastNotificationIntent();
        if(0 != 0)
        {
                UnityEngine.Debug.Log(message:  -1610610175);
        }
        
        Unity.Notifications.Android.AndroidNotificationCenter.add_OnNotificationReceived(value:  536897887);
    }
    private void PushNotification(string title, string text, int time)
    {
        bool val_6;
        System.DateTime val_1 = System.DateTime.Now;
        System.DateTime val_4 = AddMinutes(value:  null);
        val_6 = mem[536883422];
        if((val_6 & true) == 0)
        {
                val_6 = mem[536883351];
        }
        
        do
        {
            var val_5 = 80 - 8;
        }
        while(val_6 != 0);
        
        int val_6 = Unity.Notifications.Android.AndroidNotificationCenter.SendNotification(notification:  new Unity.Notifications.Android.AndroidNotification() {<FireTime>k__BackingField = new System.DateTime(), <ShouldAutoCancel>k__BackingField = false, <UsesStopwatch>k__BackingField = false, <GroupSummary>k__BackingField = false, <ShowTimestamp>k__BackingField = false, <ShowCustomTimestamp>k__BackingField = false, m_Color = new UnityEngine.Color(), m_RepeatInterval = new System.TimeSpan(), m_CustomTimestamp = new System.DateTime()}, channelId:  -1610599263);
    }
    private void PushNotification_Span(string title, string text, int time, float timeSpan, NotificationIconType iconType)
    {
        var val_1;
        bool val_18;
        var val_23;
        bool val_24;
        if(val_1 == 1)
        {
                UnityEngine.Color val_2 = UnityEngine.Color.green;
            System.Nullable<UnityEngine.Color> val_3 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {a = ???});
            title.Color = new System.Nullable<UnityEngine.Color>() {HasValue = val_3.HasValue};
            System.DateTime val_4 = System.DateTime.Now;
            System.DateTime val_7 = AddMinutes(value:  null);
            System.TimeSpan val_8 = System.TimeSpan.FromHours(value:  null);
            System.Nullable<System.TimeSpan> val_9 = new System.Nullable<System.TimeSpan>(value:  new System.TimeSpan() {_ticks = 8});
            title.RepeatInterval = new System.Nullable<System.TimeSpan>() {HasValue = true};
            val_18 = mem[536883422];
            if((val_18 & true) == 0)
        {
                val_18 = mem[536883351];
        }
        
            do
        {
            val_23 = 80 - 8;
        }
        while(val_18 != 0);
        
        }
        else
        {
                UnityEngine.Color val_11 = UnityEngine.Color.green;
            System.Nullable<UnityEngine.Color> val_12 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {a = ???});
            title.Color = new System.Nullable<UnityEngine.Color>() {HasValue = val_12.HasValue};
            System.DateTime val_13 = System.DateTime.Now;
            System.DateTime val_14 = AddMinutes(value:  null);
            System.TimeSpan val_15 = System.TimeSpan.FromHours(value:  null);
            System.Nullable<System.TimeSpan> val_16 = new System.Nullable<System.TimeSpan>(value:  new System.TimeSpan() {_ticks = 8});
            title.RepeatInterval = new System.Nullable<System.TimeSpan>() {HasValue = true};
            val_24 = mem[536883422];
            if((val_24 & true) == 0)
        {
                val_24 = mem[536883351];
        }
        
            do
        {
            val_23 = 80 - 8;
        }
        while(val_24 != 0);
        
        }
        
        int val_17 = Unity.Notifications.Android.AndroidNotificationCenter.SendNotification(notification:  new Unity.Notifications.Android.AndroidNotification() {<FireTime>k__BackingField = new System.DateTime() {dateData = val_16.HasValue}, <ShouldAutoCancel>k__BackingField = false, <UsesStopwatch>k__BackingField = false, <GroupSummary>k__BackingField = false, <ShowTimestamp>k__BackingField = false, <ShowCustomTimestamp>k__BackingField = false, m_Color = new UnityEngine.Color(), m_RepeatInterval = new System.TimeSpan(), m_CustomTimestamp = new System.DateTime()}, channelId:  -1610599263);
    }
    public MobileNotificationManager()
    {
        mem[536882417] = -1610602445;
        mem[536882421] = -1610607695;
        mem[536882425] = -1610606463;
        mem[536882429] = -1610609187;
        this.notificationTitles = 536882401;
        mem[536882417] = -1610602445;
        mem[536882421] = -1610607695;
        mem[536882425] = -1610606463;
        mem[536882429] = -1610609187;
        this.notificationMessages = 536882401;
    }

}
