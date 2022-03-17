using UnityEngine;
public class SiteLock : MonoBehaviour
{
    // Fields
    public bool allowLocalHost;
    public string[] allowedRemoteHosts;
    public string[] allowedLocalHosts;
    
    // Methods
    private void Start()
    {
        if(this.IsOnValidHost() != false)
        {
                UnityEngine.Time.timeScale = null;
            return;
        }
        
        if(UnityEngine.Debug.isDebugBuild == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  -1610608223);
    }
    public bool IsOnValidHost()
    {
        if(this.allowLocalHost == false)
        {
                return this.IsValidHost(hosts:  this.allowedRemoteHosts);
        }
        
        if((this.IsValidHost(hosts:  this.allowedLocalHosts)) == false)
        {
                return this.IsValidHost(hosts:  this.allowedRemoteHosts);
        }
        
        return true;
    }
    private bool IsValidHost(string[] hosts)
    {
        var val_16;
        char val_17;
        var val_18;
        if(UnityEngine.Debug.isDebugBuild == false)
        {
            goto label_3;
        }
        
        System.Text.StringBuilder val_2 = 536894635;
        val_16 = 0;
        val_2 = new System.Text.StringBuilder();
        System.Text.StringBuilder val_3 = val_2.Append(value:  -1610609361);
        goto label_5;
        label_10:
        if(val_2 != 0)
        {
                System.Text.StringBuilder val_4 = val_2.Append(value:  334878800);
        }
        else
        {
                System.Text.StringBuilder val_5 = val_2.Append(value:  334878800);
        }
        
        System.Text.StringBuilder val_6 = val_2.Append(value:  -1610611911);
        val_16 = 1;
        label_5:
        if(val_16 < val_2)
        {
            goto label_10;
        }
        
        UnityEngine.Debug.Log(message:  536894635);
        label_3:
        536892635 = new System.Text.RegularExpressions.Regex(pattern:  -1610602183);
        string val_8 = UnityEngine.Application.absoluteURL;
        val_17 = 0;
        val_18 = 0;
        System.Text.RegularExpressions.Match val_9 = 536892635.Match(input:  null);
        if(536892635.Success == false)
        {
                return (bool)val_18;
        }
        
        System.Text.RegularExpressions.Group val_11 = 536892635.Item[-1610600153];
        string val_12 = 536892635.Value;
        val_17 = -1610611787.Chars[0];
        mem[536881809] = val_17;
        var val_16 = 0;
        System.String[] val_14 = 536892635.Split(separator:  536881793);
        label_27:
        if(val_16 >= 536892635)
        {
            goto label_25;
        }
        
        val_16 = val_16 + 1;
        if((this.DoesHostMatch(allowedHost:  334878800, applicationHost:  536892635)) == false)
        {
            goto label_27;
        }
        
        val_18 = 1;
        return (bool)val_18;
        label_25:
        val_18 = 0;
        return (bool)val_18;
    }
    private bool DoesHostMatch(string allowedHost, string[] applicationHost)
    {
        var val_6;
        char val_7;
        var val_8;
        val_6 = 536881793;
        mem[536881809] = -1610611787.Chars[0];
        System.String[] val_2 = allowedHost.Split(separator:  536881793);
        val_7 = allowedHost.m_firstChar;
        val_8 = 0;
        if(val_6 < val_7)
        {
                return (bool)val_8;
        }
        
        if(val_7 >= '')
        {
                string val_3 = allowedHost + 16;
            var val_7 = 0;
            val_8 = 0;
            do
        {
            if(val_7 <= val_7)
        {
                val_7 = allowedHost.m_firstChar;
        }
        
            val_7 = 0 - val_7;
            if((1152921504621649920.Equals(value:  applicationHost[val_7 + val_7])) == false)
        {
                return (bool)val_8;
        }
        
            val_7 = val_7 + 1;
        }
        while(val_7 < allowedHost.m_firstChar);
        
        }
        
        val_8 = 1;
        return (bool)val_8;
    }
    private bool IsOnValidLocalHost()
    {
        if(this.allowLocalHost == false)
        {
                this = 0;
            return (bool)this;
        }
        
        return this.IsValidHost(hosts:  1);
    }
    private bool IsOnValidRemoteHost()
    {
        return this.IsValidHost(hosts:  this.allowedRemoteHosts);
    }
    private void Crash(int i)
    {
    
    }
    public SiteLock()
    {
        this.allowLocalHost = true;
        mem[536882417] = -1610601099;
        mem[536882421] = -1610600313;
        mem[536882425] = -1610611449;
        mem[536882429] = -1610598091;
        mem[536882433] = -1610598943;
        mem[536882437] = -1610600827;
        this.allowedRemoteHosts = 536882401;
        mem[536882417] = -1610599395;
        this.allowedLocalHosts = 536882401;
    }

}
