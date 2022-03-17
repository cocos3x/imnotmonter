using UnityEngine;

namespace AFramework
{
    public class SaveGameManager : Singleton<AFramework.SaveGameManager>
    {
        // Fields
        private const string MANDATORY_SAVE_NAME = "mwovjtpamcjaytifnhyqlbprths";
        private const string OPTIONAL_SAVE_NAME = "nalgowuthvnapqyewngoapwvz";
        private AFramework.SaveGameManager.SaveGameDictionary mMandatory;
        private AFramework.SaveGameManager.SaveGameDictionary mOptional;
        
        // Methods
        public void RegisterMandatoryData(string name, AFramework.ISaveData data)
        {
            this.mMandatory.set_Item(key:  name, value:  data);
        }
        public void RegisterOptionalData(string name, AFramework.ISaveData data)
        {
            this.mOptional.set_Item(key:  name, value:  data);
        }
        public void Save(bool mandatory = True, bool optional = True, bool hasBackup = True)
        {
            bool val_44;
            float val_45;
            string val_46;
            var val_47;
            string val_48;
            float val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            val_44 = optional;
            val_45 = 0;
            if(mandatory == false)
            {
                goto label_72;
            }
            
            System.Collections.Generic.ICollection<TKey> val_1 = mem[1152921510077540312].Keys;
            string val_44 = mem[1152921510077540312];
            if((mem[1152921510077540312] + 178) == 0)
            {
                goto label_4;
            }
            
            var val_43 = 0;
            label_6:
            val_46 = 0;
            if((mem[1152921510077540312] + 88 + 0) == 536876415)
            {
                goto label_5;
            }
            
            val_43 = val_43 + 1;
            val_46 = (uint)val_43 & 65535;
            if(val_46 < (mem[1152921510077540312] + 178))
            {
                goto label_6;
            }
            
            label_4:
            val_47 = mem[1152921510077540312];
            goto label_7;
            label_5:
            var val_2 = (mem[1152921510077540312] + 88) + 0;
            val_44 = val_44 + (((mem[1152921510077540312] + 88 + 0) + 4) << 3);
            val_47 = val_44 + 188;
            label_7:
            val_48 = 0;
            val_49 = 4.01422E-38f;
            goto label_8;
            label_25:
            string val_46 = mem[1152921510077540312];
            if((mem[1152921510077540312] + 178) == 0)
            {
                goto label_10;
            }
            
            var val_45 = 0;
            label_12:
            if((mem[1152921510077540312] + 88 + 0) == 536876687)
            {
                goto label_11;
            }
            
            val_45 = val_45 + 1;
            if(((uint)val_45 & 65535) < (mem[1152921510077540312] + 178))
            {
                goto label_12;
            }
            
            label_10:
            val_50 = mem[1152921510077540312];
            goto label_13;
            label_11:
            var val_3 = (mem[1152921510077540312] + 88) + 0;
            val_46 = val_46 + (((mem[1152921510077540312] + 88 + 0) + 4) << 3);
            val_50 = val_46 + 188;
            label_13:
            string val_4 = mem[1152921510077540312].Item[mem[1152921510077540312]];
            val_46 = mem[1152921510077540312];
            var val_48 = val_46;
            if((mem[1152921510077540312] + 178) == 0)
            {
                goto label_16;
            }
            
            var val_47 = 0;
            label_18:
            if((mem[1152921510077540312] + 88 + 0) == 536888679)
            {
                goto label_17;
            }
            
            val_47 = val_47 + 1;
            if(((uint)val_47 & 65535) < (mem[1152921510077540312] + 178))
            {
                goto label_18;
            }
            
            label_16:
            val_51 = val_46;
            goto label_19;
            label_17:
            var val_5 = (mem[1152921510077540312] + 88) + 0;
            val_48 = val_48 + (((mem[1152921510077540312] + 88 + 0) + 4) << 3);
            val_51 = val_48 + 220;
            label_19:
            val_48 = val_48 | val_46;
            label_8:
            string val_50 = mem[1152921510077540312];
            if((mem[1152921510077540312] + 178) == 0)
            {
                goto label_21;
            }
            
            var val_49 = 0;
            label_23:
            val_46 = 0;
            if((mem[1152921510077540312] + 88 + 0) == 536888219)
            {
                goto label_22;
            }
            
            val_49 = val_49 + 1;
            val_46 = (uint)val_49 & 65535;
            if(val_46 < (mem[1152921510077540312] + 178))
            {
                goto label_23;
            }
            
            label_21:
            val_52 = mem[1152921510077540312];
            goto label_24;
            label_22:
            var val_6 = (mem[1152921510077540312] + 88) + 0;
            val_50 = val_50 + (((mem[1152921510077540312] + 88 + 0) + 4) << 3);
            val_52 = val_50 + 188;
            label_24:
            if(mem[1152921510077540312] != 0)
            {
                goto label_25;
            }
            
            if(mem[1152921510077540312] == 0)
            {
                goto label_26;
            }
            
            string val_52 = mem[1152921510077540312];
            if((mem[1152921510077540312] + 178) == 0)
            {
                goto label_27;
            }
            
            var val_51 = 0;
            label_29:
            val_46 = 0;
            if((mem[1152921510077540312] + 88 + 0) == 536888187)
            {
                goto label_28;
            }
            
            val_51 = val_51 + 1;
            val_46 = (uint)val_51 & 65535;
            if(val_46 < (mem[1152921510077540312] + 178))
            {
                goto label_29;
            }
            
            label_27:
            val_53 = mem[1152921510077540312];
            goto label_30;
            label_28:
            var val_7 = (mem[1152921510077540312] + 88) + 0;
            val_52 = val_52 + (((mem[1152921510077540312] + 88 + 0) + 4) << 3);
            val_53 = val_52 + 188;
            label_30:
            label_26:
            var val_53 = 1;
            if(val_53 != 0)
            {
                    val_53 = val_53 - 1;
            }
            
            val_44 = val_44;
            val_45 = 0;
            if((val_48 & 1) != 0)
            {
                goto label_72;
            }
            
            SaveGameManager.LoadGameDictionary val_8 = 536900863;
            val_8 = new SaveGameManager.LoadGameDictionary();
            System.Collections.Generic.ICollection<TKey> val_9 = mem[1152921510077540312].Keys;
            val_46 = mem[1152921510077540312];
            var val_55 = val_46;
            if((mem[1152921510077540312] + 178) == 0)
            {
                goto label_36;
            }
            
            var val_54 = 0;
            label_38:
            if((mem[1152921510077540312] + 88 + 0) == 536876415)
            {
                goto label_37;
            }
            
            val_54 = val_54 + 1;
            if(((uint)val_54 & 65535) < (mem[1152921510077540312] + 178))
            {
                goto label_38;
            }
            
            label_36:
            val_54 = val_46;
            goto label_39;
            label_37:
            var val_10 = (mem[1152921510077540312] + 88) + 0;
            val_55 = val_55 + (((mem[1152921510077540312] + 88 + 0) + 4) << 3);
            val_54 = val_55 + 188;
            label_39:
            val_48 = 0;
            label_64:
            var val_57 = val_46;
            if((mem[1152921510077540312] + 178) == 0)
            {
                goto label_41;
            }
            
            var val_56 = 0;
            label_43:
            val_46 = mem[mem[1152921510077540312] + 88 + 0];
            val_46 = mem[1152921510077540312] + 88 + 0;
            if(val_46 == 536888219)
            {
                goto label_42;
            }
            
            val_56 = val_56 + 1;
            val_46 = (uint)val_56 & 65535;
            if(val_46 < (mem[1152921510077540312] + 178))
            {
                goto label_43;
            }
            
            label_41:
            val_55 = val_46;
            goto label_44;
            label_42:
            var val_11 = (mem[1152921510077540312] + 88) + 0;
            val_57 = val_57 + (((mem[1152921510077540312] + 88 + 0) + 4) << 3);
            val_55 = val_57 + 188;
            label_44:
            if(val_46 == 0)
            {
                goto label_45;
            }
            
            var val_59 = val_46;
            if((mem[1152921510077540312] + 178) == 0)
            {
                goto label_47;
            }
            
            var val_58 = 0;
            label_49:
            if((mem[1152921510077540312] + 88 + 0) == 536876687)
            {
                goto label_48;
            }
            
            val_58 = val_58 + 1;
            if(((uint)val_58 & 65535) < (mem[1152921510077540312] + 178))
            {
                goto label_49;
            }
            
            label_47:
            val_56 = val_46;
            goto label_50;
            label_48:
            var val_12 = (mem[1152921510077540312] + 88) + 0;
            val_59 = val_59 + (((mem[1152921510077540312] + 88 + 0) + 4) << 3);
            val_56 = val_59 + 188;
            label_50:
            string val_13 = mem[1152921510077540312].Item[val_46];
            object val_61 = mem[1152921510077540312];
            if((mem[1152921510077540312] + 178) == 0)
            {
                goto label_53;
            }
            
            var val_60 = 0;
            label_55:
            if((mem[1152921510077540312] + 88 + 0) == 536888679)
            {
                goto label_54;
            }
            
            val_60 = val_60 + 1;
            if(((uint)val_60 & 65535) < (mem[1152921510077540312] + 178))
            {
                goto label_55;
            }
            
            label_53:
            val_57 = mem[1152921510077540312];
            val_58 = val_8;
            goto label_56;
            label_54:
            var val_14 = (mem[1152921510077540312] + 88) + 0;
            val_58 = val_8;
            val_61 = val_61 + (((mem[1152921510077540312] + 88 + 0) + 4) << 3);
            val_57 = val_61 + 188;
            label_56:
            string val_15 = UnityEngine.JsonUtility.ToJson(obj:  mem[1152921510077540312]);
            val_58.set_Item(key:  val_46, value:  mem[1152921510077540312]);
            string val_16 = mem[1152921510077540312].Item[val_46];
            var val_63 = mem[1152921510077540312];
            if((mem[1152921510077540312] + 178) == 0)
            {
                goto label_60;
            }
            
            var val_62 = 0;
            label_62:
            if((mem[1152921510077540312] + 88 + 0) == 536888679)
            {
                goto label_61;
            }
            
            val_62 = val_62 + 1;
            if(((uint)val_62 & 65535) < (mem[1152921510077540312] + 178))
            {
                goto label_62;
            }
            
            label_60:
            val_59 = mem[1152921510077540312];
            goto label_64;
            label_61:
            var val_17 = (mem[1152921510077540312] + 88) + 0;
            val_63 = val_63 + (((mem[1152921510077540312] + 88 + 0) + 4) << 3);
            val_59 = val_63 + 228;
            goto label_64;
            label_45:
            mem2[0] = 189;
            var val_64 = val_53;
            val_64 = val_64 + 1;
            if(val_46 == 0)
            {
                goto label_65;
            }
            
            var val_66 = val_46;
            if((mem[1152921510077540312] + 178) == 0)
            {
                goto label_66;
            }
            
            var val_65 = 0;
            label_68:
            val_46 = 0;
            if((mem[1152921510077540312] + 88 + 0) == 536888187)
            {
                goto label_67;
            }
            
            val_65 = val_65 + 1;
            val_46 = (uint)val_65 & 65535;
            if(val_46 < (mem[1152921510077540312] + 178))
            {
                goto label_68;
            }
            
            label_66:
            val_60 = val_46;
            goto label_69;
            label_67:
            var val_18 = (mem[1152921510077540312] + 88) + 0;
            val_66 = val_66 + (((mem[1152921510077540312] + 88 + 0) + 4) << 3);
            val_60 = val_66 + 188;
            label_69:
            label_65:
            var val_67 = val_64;
            if(val_67 != 0)
            {
                    val_67 = val_67 - 1;
            }
            
            val_44 = val_44;
            val_45 = 0;
            if((val_48 & 1) == 0)
            {
                    System.Text.Encoding val_19 = System.Text.Encoding.UTF8;
                string val_20 = UnityEngine.JsonUtility.ToJson(obj:  536900863);
                val_46 = val_8;
                val_45 = 0;
                bool val_21 = this.SaveToFile(fileName:  -1610599153, data:  null, hasBackup:  hasBackup);
            }
            
            label_72:
            if(val_44 == false)
            {
                    return;
            }
            
            System.Collections.Generic.ICollection<TKey> val_22 = mem[1152921510077540316].Keys;
            string val_68 = mem[1152921510077540316];
            if((mem[1152921510077540316] + 178) == 0)
            {
                goto label_77;
            }
            
            val_44 = 0;
            label_79:
            val_46 = 0;
            if((mem[1152921510077540316] + 88 + 0) == 536876415)
            {
                goto label_78;
            }
            
            val_44 = val_44 + 1;
            val_46 = (uint)val_44 & 65535;
            if(val_46 < (mem[1152921510077540316] + 178))
            {
                goto label_79;
            }
            
            label_77:
            val_61 = mem[1152921510077540316];
            goto label_80;
            label_78:
            var val_23 = (mem[1152921510077540316] + 88) + 0;
            val_68 = val_68 + (((mem[1152921510077540316] + 88 + 0) + 4) << 3);
            val_61 = val_68 + 188;
            label_80:
            val_49 = mem[1152921510077540316];
            val_48 = 0;
            val_45 = 4.01422E-38f;
            goto label_81;
            label_98:
            var val_70 = val_49;
            if((mem[1152921510077540316] + 178) == 0)
            {
                goto label_83;
            }
            
            var val_69 = 0;
            label_85:
            if((mem[1152921510077540316] + 88 + 0) == 536876687)
            {
                goto label_84;
            }
            
            val_69 = val_69 + 1;
            if(((uint)val_69 & 65535) < (mem[1152921510077540316] + 178))
            {
                goto label_85;
            }
            
            label_83:
            val_62 = val_49;
            goto label_86;
            label_84:
            var val_24 = (mem[1152921510077540316] + 88) + 0;
            val_70 = val_70 + (((mem[1152921510077540316] + 88 + 0) + 4) << 3);
            val_62 = val_70 + 188;
            label_86:
            val_44 = mem[1152921510077540316];
            string val_25 = val_44.Item[val_49];
            val_46 = val_44;
            var val_71 = val_46;
            if((mem[1152921510077540316] + 178) == 0)
            {
                goto label_89;
            }
            
            val_44 = 0;
            label_91:
            if((mem[1152921510077540316] + 88 + 0) == 536888679)
            {
                goto label_90;
            }
            
            val_44 = val_44 + 1;
            if(((uint)val_44 & 65535) < (mem[1152921510077540316] + 178))
            {
                goto label_91;
            }
            
            label_89:
            val_63 = val_46;
            goto label_92;
            label_90:
            var val_26 = (mem[1152921510077540316] + 88) + 0;
            val_71 = val_71 + (((mem[1152921510077540316] + 88 + 0) + 4) << 3);
            val_63 = val_71 + 220;
            label_92:
            val_48 = val_48 | val_46;
            label_81:
            var val_72 = val_49;
            if((mem[1152921510077540316] + 178) == 0)
            {
                goto label_94;
            }
            
            val_44 = 0;
            label_96:
            val_46 = 0;
            if((mem[1152921510077540316] + 88 + 0) == 536888219)
            {
                goto label_95;
            }
            
            val_44 = val_44 + 1;
            val_46 = (uint)val_44 & 65535;
            if(val_46 < (mem[1152921510077540316] + 178))
            {
                goto label_96;
            }
            
            label_94:
            val_64 = val_49;
            goto label_97;
            label_95:
            var val_27 = (mem[1152921510077540316] + 88) + 0;
            val_72 = val_72 + (((mem[1152921510077540316] + 88 + 0) + 4) << 3);
            val_64 = val_72 + 188;
            label_97:
            if(val_49 != 0)
            {
                goto label_98;
            }
            
            mem2[0] = 310;
            var val_73 = val_67;
            val_73 = val_73 + 1;
            if(val_49 == 0)
            {
                goto label_99;
            }
            
            var val_74 = val_49;
            if((mem[1152921510077540316] + 178) == 0)
            {
                goto label_100;
            }
            
            val_44 = 0;
            label_102:
            val_46 = 0;
            if((mem[1152921510077540316] + 88 + 0) == 536888187)
            {
                goto label_101;
            }
            
            val_44 = val_44 + 1;
            val_46 = (uint)val_44 & 65535;
            if(val_46 < (mem[1152921510077540316] + 178))
            {
                goto label_102;
            }
            
            label_100:
            val_65 = val_49;
            goto label_103;
            label_101:
            var val_28 = (mem[1152921510077540316] + 88) + 0;
            val_74 = val_74 + (((mem[1152921510077540316] + 88 + 0) + 4) << 3);
            val_65 = val_74 + 188;
            label_103:
            label_99:
            var val_75 = val_73;
            if(val_75 != 0)
            {
                    val_75 = val_75 - 1;
            }
            
            if((val_48 & 1) != 0)
            {
                    return;
            }
            
            SaveGameManager.LoadGameDictionary val_29 = 536900863;
            val_29 = new SaveGameManager.LoadGameDictionary();
            System.Collections.Generic.ICollection<TKey> val_30 = mem[1152921510077540316].Keys;
            val_46 = mem[1152921510077540316];
            var val_77 = val_46;
            if((mem[1152921510077540316] + 178) == 0)
            {
                goto label_109;
            }
            
            var val_76 = 0;
            label_111:
            if((mem[1152921510077540316] + 88 + 0) == 536876415)
            {
                goto label_110;
            }
            
            val_76 = val_76 + 1;
            if(((uint)val_76 & 65535) < (mem[1152921510077540316] + 178))
            {
                goto label_111;
            }
            
            label_109:
            val_66 = val_46;
            goto label_112;
            label_110:
            var val_31 = (mem[1152921510077540316] + 88) + 0;
            val_77 = val_77 + (((mem[1152921510077540316] + 88 + 0) + 4) << 3);
            val_66 = val_77 + 188;
            label_112:
            val_48 = val_46;
            val_45 = 0;
            label_137:
            var val_79 = val_48;
            if((mem[1152921510077540316] + 178) == 0)
            {
                goto label_114;
            }
            
            var val_78 = 0;
            label_116:
            val_46 = mem[mem[1152921510077540316] + 88 + 0];
            val_46 = mem[1152921510077540316] + 88 + 0;
            if(val_46 == 536888219)
            {
                goto label_115;
            }
            
            val_78 = val_78 + 1;
            val_46 = (uint)val_78 & 65535;
            if(val_46 < (mem[1152921510077540316] + 178))
            {
                goto label_116;
            }
            
            label_114:
            val_67 = val_48;
            goto label_117;
            label_115:
            var val_32 = (mem[1152921510077540316] + 88) + 0;
            val_79 = val_79 + (((mem[1152921510077540316] + 88 + 0) + 4) << 3);
            val_67 = val_79 + 188;
            label_117:
            if(val_48 == 0)
            {
                goto label_118;
            }
            
            var val_81 = val_48;
            if((mem[1152921510077540316] + 178) == 0)
            {
                goto label_120;
            }
            
            var val_80 = 0;
            label_122:
            if((mem[1152921510077540316] + 88 + 0) == 536876687)
            {
                goto label_121;
            }
            
            val_80 = val_80 + 1;
            if(((uint)val_80 & 65535) < (mem[1152921510077540316] + 178))
            {
                goto label_122;
            }
            
            label_120:
            val_68 = val_48;
            goto label_123;
            label_121:
            var val_33 = (mem[1152921510077540316] + 88) + 0;
            val_81 = val_81 + (((mem[1152921510077540316] + 88 + 0) + 4) << 3);
            val_68 = val_81 + 188;
            label_123:
            string val_34 = mem[1152921510077540316].Item[val_48];
            object val_83 = mem[1152921510077540316];
            if((mem[1152921510077540316] + 178) == 0)
            {
                goto label_126;
            }
            
            var val_82 = 0;
            label_128:
            if((mem[1152921510077540316] + 88 + 0) == 536888679)
            {
                goto label_127;
            }
            
            val_82 = val_82 + 1;
            if(((uint)val_82 & 65535) < (mem[1152921510077540316] + 178))
            {
                goto label_128;
            }
            
            label_126:
            val_69 = mem[1152921510077540316];
            val_70 = val_29;
            goto label_129;
            label_127:
            var val_35 = (mem[1152921510077540316] + 88) + 0;
            val_70 = val_29;
            val_83 = val_83 + (((mem[1152921510077540316] + 88 + 0) + 4) << 3);
            val_69 = val_83 + 188;
            label_129:
            string val_36 = UnityEngine.JsonUtility.ToJson(obj:  mem[1152921510077540316]);
            val_70.set_Item(key:  val_48, value:  mem[1152921510077540316]);
            string val_37 = mem[1152921510077540316].Item[val_48];
            var val_85 = mem[1152921510077540316];
            if((mem[1152921510077540316] + 178) == 0)
            {
                goto label_133;
            }
            
            var val_84 = 0;
            label_135:
            if((mem[1152921510077540316] + 88 + 0) == 536888679)
            {
                goto label_134;
            }
            
            val_84 = val_84 + 1;
            if(((uint)val_84 & 65535) < (mem[1152921510077540316] + 178))
            {
                goto label_135;
            }
            
            label_133:
            val_71 = mem[1152921510077540316];
            goto label_137;
            label_134:
            var val_38 = (mem[1152921510077540316] + 88) + 0;
            val_85 = val_85 + (((mem[1152921510077540316] + 88 + 0) + 4) << 3);
            val_71 = val_85 + 228;
            goto label_137;
            label_118:
            val_44 = 0;
            mem2[0] = 428;
            var val_86 = val_75;
            val_86 = val_86 + 1;
            if(val_48 == 0)
            {
                goto label_138;
            }
            
            var val_88 = val_48;
            if((mem[1152921510077540316] + 178) == 0)
            {
                goto label_139;
            }
            
            var val_87 = 0;
            label_141:
            val_46 = 0;
            if((mem[1152921510077540316] + 88 + 0) == 536888187)
            {
                goto label_140;
            }
            
            val_87 = val_87 + 1;
            val_46 = (uint)val_87 & 65535;
            if(val_46 < (mem[1152921510077540316] + 178))
            {
                goto label_141;
            }
            
            label_139:
            val_72 = val_48;
            goto label_142;
            label_140:
            var val_39 = (mem[1152921510077540316] + 88) + 0;
            val_88 = val_88 + (((mem[1152921510077540316] + 88 + 0) + 4) << 3);
            val_72 = val_88 + 188;
            label_142:
            label_138:
            var val_89 = val_86;
            if(val_89 != 0)
            {
                    val_89 = val_89 - 1;
            }
            
            if((val_45 & 1) != 0)
            {
                    return;
            }
            
            System.Text.Encoding val_40 = System.Text.Encoding.UTF8;
            string val_41 = UnityEngine.JsonUtility.ToJson(obj:  536900863);
            val_46 = val_29;
            bool val_42 = this.SaveToFile(fileName:  -1610599149, data:  null, hasBackup:  hasBackup);
        }
        public void Load(bool mandatory = True, bool optional = True, bool notification = True)
        {
            bool val_45;
            var val_46;
            var val_47;
            string val_48;
            var val_49;
            var val_50;
            string val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_74;
            var val_75;
            val_45 = mandatory;
            if(val_45 == false)
            {
                goto label_41;
            }
            
            if((this.LoadFromFile(fileName:  -1610599153, data: ref  System.Byte[] val_1 = 1175825992, hasBackup:  false)) != true)
            {
                    bool val_4 = this.LoadFromFile(fileName:  -1610601911, data: ref  System.Byte[] val_3 = 1175825992, hasBackup:  false);
            }
            
            if(0 != 0)
            {
                    System.Text.Encoding val_5 = System.Text.Encoding.UTF8;
                val_46 = 0;
            }
            else
            {
                    val_46 = -1610596953;
            }
            
            LoadGameDictionary val_6 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  -1610596953);
            val_48 = val_46;
            System.Collections.Generic.ICollection<TKey> val_7 = mem[1152921510077652312].Keys;
            string val_45 = mem[1152921510077652312];
            if((mem[1152921510077652312] + 178) == 0)
            {
                goto label_9;
            }
            
            val_49 = 0;
            label_11:
            val_47 = mem[mem[1152921510077652312] + 88 + 0];
            val_47 = mem[1152921510077652312] + 88 + 0;
            if(val_47 == 536876415)
            {
                goto label_10;
            }
            
            val_49 = val_49 + 1;
            val_47 = (uint)val_49 & 65535;
            if(val_47 < (mem[1152921510077652312] + 178))
            {
                goto label_11;
            }
            
            label_9:
            val_50 = mem[1152921510077652312];
            goto label_12;
            label_10:
            var val_8 = (mem[1152921510077652312] + 88) + 0;
            val_45 = val_45 + (((mem[1152921510077652312] + 88 + 0) + 4) << 3);
            val_50 = val_45 + 188;
            label_12:
            val_51 = mem[1152921510077652312];
            label_34:
            var val_46 = val_51;
            if((mem[1152921510077652312] + 178) == 0)
            {
                goto label_14;
            }
            
            val_49 = 0;
            label_16:
            val_47 = mem[mem[1152921510077652312] + 88 + 0];
            val_47 = mem[1152921510077652312] + 88 + 0;
            if(val_47 == 536888219)
            {
                goto label_15;
            }
            
            val_49 = val_49 + 1;
            val_47 = (uint)val_49 & 65535;
            if(val_47 < (mem[1152921510077652312] + 178))
            {
                goto label_16;
            }
            
            label_14:
            val_52 = val_51;
            goto label_17;
            label_15:
            var val_9 = (mem[1152921510077652312] + 88) + 0;
            val_46 = val_46 + (((mem[1152921510077652312] + 88 + 0) + 4) << 3);
            val_52 = val_46 + 188;
            label_17:
            if(val_51 == 0)
            {
                goto label_18;
            }
            
            var val_48 = val_51;
            if((mem[1152921510077652312] + 178) == 0)
            {
                goto label_20;
            }
            
            var val_47 = 0;
            label_22:
            if((mem[1152921510077652312] + 88 + 0) == 536876687)
            {
                goto label_21;
            }
            
            val_47 = val_47 + 1;
            if(((uint)val_47 & 65535) < (mem[1152921510077652312] + 178))
            {
                goto label_22;
            }
            
            label_20:
            val_53 = val_51;
            goto label_23;
            label_21:
            var val_10 = (mem[1152921510077652312] + 88) + 0;
            val_48 = val_48 + (((mem[1152921510077652312] + 88 + 0) + 4) << 3);
            val_53 = val_48 + 188;
            label_23:
            string val_11 = mem[1152921510077652312].Item[val_51];
            if((val_48 == 0) || ((val_48.ContainsKey(key:  val_51)) == false))
            {
                goto label_27;
            }
            
            string val_13 = val_48.Item[val_51];
            if(val_48 == 0)
            {
                goto label_27;
            }
            
            string val_14 = val_48.Item[val_51];
            val_54 = val_48;
            goto label_28;
            label_27:
            val_54 = -1610612735;
            label_28:
            var val_50 = mem[1152921510077652312];
            if((mem[1152921510077652312] + 178) == 0)
            {
                goto label_30;
            }
            
            var val_49 = 0;
            label_32:
            if((mem[1152921510077652312] + 88 + 0) == 536888679)
            {
                goto label_31;
            }
            
            val_49 = val_49 + 1;
            if(((uint)val_49 & 65535) < (mem[1152921510077652312] + 178))
            {
                goto label_32;
            }
            
            label_30:
            val_55 = mem[1152921510077652312];
            goto label_34;
            label_31:
            var val_15 = (mem[1152921510077652312] + 88) + 0;
            val_50 = val_50 + (((mem[1152921510077652312] + 88 + 0) + 4) << 3);
            val_55 = val_50 + 196;
            goto label_34;
            label_18:
            val_56 = 0;
            val_45 = val_45;
            if(val_51 == 0)
            {
                goto label_35;
            }
            
            var val_51 = val_51;
            if((mem[1152921510077652312] + 178) == 0)
            {
                goto label_36;
            }
            
            val_47 = 0;
            label_38:
            val_49 = 0;
            if((mem[1152921510077652312] + 88 + 0) == 536888187)
            {
                goto label_37;
            }
            
            val_47 = val_47 + 1;
            val_49 = (uint)val_47 & 65535;
            if(val_49 < (mem[1152921510077652312] + 178))
            {
                goto label_38;
            }
            
            label_36:
            val_57 = val_51;
            goto label_39;
            label_37:
            var val_16 = (mem[1152921510077652312] + 88) + 0;
            val_51 = val_51 + (((mem[1152921510077652312] + 88 + 0) + 4) << 3);
            val_57 = val_51 + 188;
            label_39:
            label_35:
            var val_52 = 1;
            if(val_52 != 0)
            {
                    val_52 = val_52 - 1;
            }
            
            label_41:
            if(optional == false)
            {
                goto label_82;
            }
            
            if((this.LoadFromFile(fileName:  -1610599149, data: ref  System.Byte[] val_17 = 1175825988, hasBackup:  false)) != true)
            {
                    bool val_20 = this.LoadFromFile(fileName:  -1610601909, data: ref  System.Byte[] val_19 = 1175825988, hasBackup:  false);
            }
            
            if(0 != 0)
            {
                    System.Text.Encoding val_21 = System.Text.Encoding.UTF8;
                val_58 = 0;
            }
            else
            {
                    val_58 = -1610596953;
            }
            
            LoadGameDictionary val_22 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  -1610596953);
            val_51 = val_58;
            System.Collections.Generic.ICollection<TKey> val_23 = mem[1152921510077652316].Keys;
            string val_53 = mem[1152921510077652316];
            if((mem[1152921510077652316] + 178) == 0)
            {
                goto label_50;
            }
            
            val_49 = 0;
            label_52:
            val_47 = 0;
            if((mem[1152921510077652316] + 88 + 0) == 536876415)
            {
                goto label_51;
            }
            
            val_49 = val_49 + 1;
            val_47 = (uint)val_49 & 65535;
            if(val_47 < (mem[1152921510077652316] + 178))
            {
                goto label_52;
            }
            
            label_50:
            val_59 = mem[1152921510077652316];
            goto label_53;
            label_51:
            var val_24 = (mem[1152921510077652316] + 88) + 0;
            val_53 = val_53 + (((mem[1152921510077652316] + 88 + 0) + 4) << 3);
            val_59 = val_53 + 188;
            label_53:
            val_48 = mem[1152921510077652316];
            label_75:
            var val_54 = val_48;
            if((mem[1152921510077652316] + 178) == 0)
            {
                goto label_55;
            }
            
            val_47 = 0;
            label_57:
            val_49 = 0;
            if((mem[1152921510077652316] + 88 + 0) == 536888219)
            {
                goto label_56;
            }
            
            val_47 = val_47 + 1;
            val_49 = (uint)val_47 & 65535;
            if(val_49 < (mem[1152921510077652316] + 178))
            {
                goto label_57;
            }
            
            label_55:
            val_60 = val_48;
            goto label_58;
            label_56:
            var val_25 = (mem[1152921510077652316] + 88) + 0;
            val_54 = val_54 + (((mem[1152921510077652316] + 88 + 0) + 4) << 3);
            val_60 = val_54 + 188;
            label_58:
            if(val_48 == 0)
            {
                goto label_59;
            }
            
            var val_56 = val_48;
            if((mem[1152921510077652316] + 178) == 0)
            {
                goto label_61;
            }
            
            var val_55 = 0;
            label_63:
            if((mem[1152921510077652316] + 88 + 0) == 536876687)
            {
                goto label_62;
            }
            
            val_55 = val_55 + 1;
            if(((uint)val_55 & 65535) < (mem[1152921510077652316] + 178))
            {
                goto label_63;
            }
            
            label_61:
            val_61 = val_48;
            goto label_64;
            label_62:
            var val_26 = (mem[1152921510077652316] + 88) + 0;
            val_56 = val_56 + (((mem[1152921510077652316] + 88 + 0) + 4) << 3);
            val_61 = val_56 + 188;
            label_64:
            string val_27 = mem[1152921510077652316].Item[val_48];
            if((val_51 == 0) || ((val_51.ContainsKey(key:  val_48)) == false))
            {
                goto label_68;
            }
            
            string val_29 = val_51.Item[val_48];
            if(val_51 == 0)
            {
                goto label_68;
            }
            
            string val_30 = val_51.Item[val_48];
            val_62 = val_51;
            goto label_69;
            label_68:
            val_62 = -1610612735;
            label_69:
            var val_58 = mem[1152921510077652316];
            if((mem[1152921510077652316] + 178) == 0)
            {
                goto label_71;
            }
            
            var val_57 = 0;
            label_73:
            if((mem[1152921510077652316] + 88 + 0) == 536888679)
            {
                goto label_72;
            }
            
            val_57 = val_57 + 1;
            if(((uint)val_57 & 65535) < (mem[1152921510077652316] + 178))
            {
                goto label_73;
            }
            
            label_71:
            val_63 = mem[1152921510077652316];
            goto label_75;
            label_72:
            var val_31 = (mem[1152921510077652316] + 88) + 0;
            val_58 = val_58 + (((mem[1152921510077652316] + 88 + 0) + 4) << 3);
            val_63 = val_58 + 196;
            goto label_75;
            label_59:
            mem2[0] = 370;
            var val_59 = val_52;
            val_59 = val_59 + 1;
            if(val_48 == 0)
            {
                goto label_76;
            }
            
            var val_60 = val_48;
            if((mem[1152921510077652316] + 178) == 0)
            {
                goto label_77;
            }
            
            val_47 = 0;
            label_79:
            val_49 = 0;
            if((mem[1152921510077652316] + 88 + 0) == 536888187)
            {
                goto label_78;
            }
            
            val_47 = val_47 + 1;
            val_49 = (uint)val_47 & 65535;
            if(val_49 < (mem[1152921510077652316] + 178))
            {
                goto label_79;
            }
            
            label_77:
            val_64 = val_48;
            goto label_80;
            label_78:
            var val_32 = (mem[1152921510077652316] + 88) + 0;
            val_60 = val_60 + (((mem[1152921510077652316] + 88 + 0) + 4) << 3);
            val_64 = val_60 + 188;
            label_80:
            label_76:
            var val_61 = val_59;
            val_45 = val_45;
            if(val_61 != 0)
            {
                    val_61 = val_61 - 1;
            }
            
            label_82:
            if(notification == false)
            {
                    return;
            }
            
            if(val_45 == false)
            {
                goto label_114;
            }
            
            System.Collections.Generic.ICollection<TValue> val_33 = mem[1152921510077652312].Values;
            var val_62 = mem[1152921510077652312];
            if((mem[1152921510077652312] + 178) == 0)
            {
                goto label_87;
            }
            
            val_47 = 0;
            label_89:
            val_49 = 0;
            if((mem[1152921510077652312] + 88 + 0) == 536876381)
            {
                goto label_88;
            }
            
            val_47 = val_47 + 1;
            val_49 = (uint)val_47 & 65535;
            if(val_49 < (mem[1152921510077652312] + 178))
            {
                goto label_89;
            }
            
            label_87:
            val_65 = mem[1152921510077652312];
            goto label_90;
            label_88:
            var val_34 = (mem[1152921510077652312] + 88) + 0;
            val_62 = val_62 + (((mem[1152921510077652312] + 88 + 0) + 4) << 3);
            val_65 = val_62 + 188;
            label_90:
            val_56 = mem[1152921510077652312];
            val_51 = 4.01422E-38f;
            val_48 = 4.014328E-38f;
            label_107:
            var val_63 = val_56;
            if((mem[1152921510077652312] + 178) == 0)
            {
                goto label_92;
            }
            
            val_47 = 0;
            label_94:
            val_49 = mem[mem[1152921510077652312] + 88 + 0];
            val_49 = mem[1152921510077652312] + 88 + 0;
            if(val_49 == 536888219)
            {
                goto label_93;
            }
            
            val_47 = val_47 + 1;
            val_49 = (uint)val_47 & 65535;
            if(val_49 < (mem[1152921510077652312] + 178))
            {
                goto label_94;
            }
            
            label_92:
            val_66 = val_56;
            goto label_95;
            label_93:
            var val_35 = (mem[1152921510077652312] + 88) + 0;
            val_63 = val_63 + (((mem[1152921510077652312] + 88 + 0) + 4) << 3);
            val_66 = val_63 + 188;
            label_95:
            if(val_56 == 0)
            {
                goto label_96;
            }
            
            var val_65 = val_56;
            if((mem[1152921510077652312] + 178) == 0)
            {
                goto label_98;
            }
            
            var val_64 = 0;
            label_100:
            if((mem[1152921510077652312] + 88 + 0) == 536876661)
            {
                goto label_99;
            }
            
            val_64 = val_64 + 1;
            if(((uint)val_64 & 65535) < (mem[1152921510077652312] + 178))
            {
                goto label_100;
            }
            
            label_98:
            val_67 = val_56;
            goto label_101;
            label_99:
            var val_36 = (mem[1152921510077652312] + 88) + 0;
            val_65 = val_65 + (((mem[1152921510077652312] + 88 + 0) + 4) << 3);
            val_67 = val_65 + 188;
            label_101:
            var val_67 = val_56;
            if((mem[1152921510077652312] + 178) == 0)
            {
                goto label_103;
            }
            
            var val_66 = 0;
            label_105:
            if((mem[1152921510077652312] + 88 + 0) == 536888679)
            {
                goto label_104;
            }
            
            val_66 = val_66 + 1;
            if(((uint)val_66 & 65535) < (mem[1152921510077652312] + 178))
            {
                goto label_105;
            }
            
            label_103:
            val_68 = val_56;
            goto label_107;
            label_104:
            var val_37 = (mem[1152921510077652312] + 88) + 0;
            val_67 = val_67 + (((mem[1152921510077652312] + 88 + 0) + 4) << 3);
            val_68 = val_67 + 204;
            goto label_107;
            label_96:
            mem2[0] = 431;
            var val_68 = val_61;
            val_68 = val_68 + 1;
            if(val_56 == 0)
            {
                goto label_108;
            }
            
            var val_69 = val_56;
            if((mem[1152921510077652312] + 178) == 0)
            {
                goto label_109;
            }
            
            val_47 = 0;
            label_111:
            val_49 = 0;
            if((mem[1152921510077652312] + 88 + 0) == 536888187)
            {
                goto label_110;
            }
            
            val_47 = val_47 + 1;
            val_49 = (uint)val_47 & 65535;
            if(val_49 < (mem[1152921510077652312] + 178))
            {
                goto label_111;
            }
            
            label_109:
            val_69 = val_56;
            goto label_112;
            label_110:
            var val_38 = (mem[1152921510077652312] + 88) + 0;
            val_69 = val_69 + (((mem[1152921510077652312] + 88 + 0) + 4) << 3);
            val_69 = val_69 + 188;
            label_112:
            label_108:
            var val_70 = val_68;
            if(val_70 != 0)
            {
                    val_70 = val_70 - 1;
            }
            
            label_114:
            if(optional == false)
            {
                    return;
            }
            
            System.Collections.Generic.ICollection<TValue> val_39 = mem[1152921510077652316].Values;
            var val_71 = mem[1152921510077652316];
            if((mem[1152921510077652316] + 178) == 0)
            {
                goto label_118;
            }
            
            val_47 = 0;
            label_120:
            val_49 = 0;
            if((mem[1152921510077652316] + 88 + 0) == 536876381)
            {
                goto label_119;
            }
            
            val_47 = val_47 + 1;
            val_49 = (uint)val_47 & 65535;
            if(val_49 < (mem[1152921510077652316] + 178))
            {
                goto label_120;
            }
            
            label_118:
            val_70 = mem[1152921510077652316];
            goto label_121;
            label_119:
            var val_40 = (mem[1152921510077652316] + 88) + 0;
            val_71 = val_71 + (((mem[1152921510077652316] + 88 + 0) + 4) << 3);
            val_70 = val_71 + 188;
            label_121:
            val_56 = mem[1152921510077652316];
            val_51 = 4.01422E-38f;
            val_48 = 4.014328E-38f;
            label_138:
            var val_72 = val_56;
            if((mem[1152921510077652316] + 178) == 0)
            {
                goto label_123;
            }
            
            val_47 = 0;
            label_125:
            val_49 = mem[mem[1152921510077652316] + 88 + 0];
            val_49 = mem[1152921510077652316] + 88 + 0;
            if(val_49 == 536888219)
            {
                goto label_124;
            }
            
            val_47 = val_47 + 1;
            val_49 = (uint)val_47 & 65535;
            if(val_49 < (mem[1152921510077652316] + 178))
            {
                goto label_125;
            }
            
            label_123:
            val_71 = val_56;
            goto label_126;
            label_124:
            var val_41 = (mem[1152921510077652316] + 88) + 0;
            val_72 = val_72 + (((mem[1152921510077652316] + 88 + 0) + 4) << 3);
            val_71 = val_72 + 188;
            label_126:
            if(val_56 == 0)
            {
                goto label_127;
            }
            
            var val_74 = val_56;
            if((mem[1152921510077652316] + 178) == 0)
            {
                goto label_129;
            }
            
            var val_73 = 0;
            label_131:
            if((mem[1152921510077652316] + 88 + 0) == 536876661)
            {
                goto label_130;
            }
            
            val_73 = val_73 + 1;
            if(((uint)val_73 & 65535) < (mem[1152921510077652316] + 178))
            {
                goto label_131;
            }
            
            label_129:
            val_72 = val_56;
            goto label_132;
            label_130:
            var val_42 = (mem[1152921510077652316] + 88) + 0;
            val_74 = val_74 + (((mem[1152921510077652316] + 88 + 0) + 4) << 3);
            val_72 = val_74 + 188;
            label_132:
            var val_76 = val_56;
            if((mem[1152921510077652316] + 178) == 0)
            {
                goto label_134;
            }
            
            var val_75 = 0;
            label_136:
            if((mem[1152921510077652316] + 88 + 0) == 536888679)
            {
                goto label_135;
            }
            
            val_75 = val_75 + 1;
            if(((uint)val_75 & 65535) < (mem[1152921510077652316] + 178))
            {
                goto label_136;
            }
            
            label_134:
            val_73 = val_56;
            goto label_138;
            label_135:
            var val_43 = (mem[1152921510077652316] + 88) + 0;
            val_76 = val_76 + (((mem[1152921510077652316] + 88 + 0) + 4) << 3);
            val_73 = val_76 + 204;
            goto label_138;
            label_127:
            val_74 = 0;
            mem2[0] = 489;
            var val_77 = val_70;
            val_77 = val_77 + 1;
            if(val_56 == 0)
            {
                goto label_139;
            }
            
            var val_78 = val_56;
            if((mem[1152921510077652316] + 178) == 0)
            {
                goto label_140;
            }
            
            val_47 = 0;
            label_142:
            val_49 = 0;
            if((mem[1152921510077652316] + 88 + 0) == 536888187)
            {
                goto label_141;
            }
            
            val_47 = val_47 + 1;
            val_49 = (uint)val_47 & 65535;
            if(val_49 < (mem[1152921510077652316] + 178))
            {
                goto label_142;
            }
            
            label_140:
            val_75 = val_56;
            goto label_143;
            label_141:
            var val_44 = (mem[1152921510077652316] + 88) + 0;
            val_78 = val_78 + (((mem[1152921510077652316] + 88 + 0) + 4) << 3);
            val_75 = val_78 + 188;
            label_143:
            label_139:
            var val_79 = val_77;
            if(val_79 == 0)
            {
                    return;
            }
            
            val_79 = val_79 - 1;
        }
        public bool SaveToFile(string fileName, byte[] data, bool hasBackup = True)
        {
            bool val_11 = hasBackup;
            string val_1 = AFramework.Utility.GetSavePath();
            if(val_11 != false)
            {
                    string val_2 = null + -1610602177(-1610602177) + fileName;
                if((System.IO.File.Exists(path:  null)) != false)
            {
                    string val_4 = null + -1610602177(-1610602177) + fileName;
                System.IO.File.Delete(path:  null);
            }
            
                string val_5 = null + fileName;
                if((System.IO.File.Exists(path:  null)) != false)
            {
                    string val_7 = null + fileName;
                val_11 = 0;
                string val_8 = null + -1610602177(-1610602177) + fileName;
                System.IO.File.Move(sourceFileName:  null, destFileName:  null);
            }
            
            }
            
            this.SimpleEncrypt(data: ref  System.Byte[] val_9 = 1175978956);
            string val_10 = null + fileName;
            System.IO.File.WriteAllBytes(path:  null, bytes:  data);
            return true;
        }
        public bool LoadFromFile(string fileName, ref byte[] data, bool hasBackup = False)
        {
            var val_11;
            string val_1 = AFramework.Utility.GetSavePath();
            string val_2 = null + fileName;
            if((System.IO.File.Exists(path:  null)) != false)
            {
                    string val_4 = null + fileName;
                System.Byte[] val_5 = System.IO.File.ReadAllBytes(path:  null);
                data = 0;
            }
            else
            {
                    string val_6 = null + -1610602177(-1610602177) + fileName;
                val_11 = 0;
                if((System.IO.File.Exists(path:  null)) == false)
            {
                    return (bool)val_11;
            }
            
                string val_8 = null + -1610602177(-1610602177) + fileName;
                System.Byte[] val_9 = System.IO.File.ReadAllBytes(path:  null);
                data = 0;
            }
            
            val_11 = 1;
            data.SimpleEncrypt(data: ref  System.Byte[] val_10 = 1176188176);
            return (bool)val_11;
        }
        private void SimpleEncrypt(ref byte[] data)
        {
            var val_4;
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            string val_2 = AFramework.Utility.GetUDID();
            val_4 = 16;
            goto label_4;
            label_11:
            if(0 >= 0)
            {
                goto label_8;
            }
            
            var val_5 = 3;
            val_5 = val_5 ^ (mem[data + val_4]);
            mem2[0] = val_5;
            val_4 = 17;
            label_4:
            var val_4 = (val_4 - 16) - (mem[data + 12]);
            if(data < null)
            {
                goto label_11;
            }
            
            return;
            label_8:
        }
        public string StringToEncryptBase64(string data)
        {
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            this.SimpleEncrypt(data: ref  System.Byte[] val_2 = 1176384316);
            string val_3 = System.Convert.ToBase64String(inArray:  null);
        }
        public string EncryptBase64ToString(string data)
        {
            System.Byte[] val_1 = System.Convert.FromBase64String(s:  data);
            data.SimpleEncrypt(data: ref  System.Byte[] val_2 = 1176504508);
            System.Text.Encoding val_3 = System.Text.Encoding.UTF8;
            if(0 != 0)
            {
                    return;
            }
        
        }
        public void DeleteAll()
        {
            bool val_1 = this.DeleteSave(fileName:  -1610599153);
            bool val_2 = this.DeleteSave(fileName:  -1610599149);
            this.mMandatory.Clear();
            this.mOptional.Clear();
        }
        public bool DeleteSave(string fileName)
        {
            string val_1 = AFramework.Utility.GetSavePath();
            string val_2 = null + fileName;
            if((System.IO.File.Exists(path:  null)) != false)
            {
                    string val_4 = null + fileName;
                System.IO.File.Delete(path:  null);
            }
            
            string val_5 = null + -1610602177(-1610602177) + fileName;
            if((System.IO.File.Exists(path:  null)) == false)
            {
                    return true;
            }
            
            string val_7 = null + -1610602177(-1610602177) + fileName;
            System.IO.File.Delete(path:  null);
            return true;
        }
        public SaveGameManager()
        {
            SaveGameManager.SaveGameDictionary val_1 = 536900867;
            val_1 = new SaveGameManager.SaveGameDictionary();
            this.mMandatory = val_1;
            SaveGameManager.SaveGameDictionary val_2 = 536900867;
            val_2 = new SaveGameManager.SaveGameDictionary();
            mem[1152921510078695484] = val_2;
            if((mem[536879706] & true) != 0)
            {
                    return;
            }
            
            if(mem[536879635] != 0)
            {
                    return;
            }
        
        }
    
    }

}
