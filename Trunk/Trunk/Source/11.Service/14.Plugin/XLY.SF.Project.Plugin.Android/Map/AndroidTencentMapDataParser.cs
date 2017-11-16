﻿/***************************************************************************
 * 
 * author :  Songbing
 * time: 2017/11/16 15:49:02 
 * explain :  
 *
*****************************************************************************/

using XLY.SF.Framework.Core.Base.CoreInterface;
using XLY.SF.Project.BaseUtility.Helper;
using XLY.SF.Project.Domains;

namespace XLY.SF.Project.Plugin.Android
{
    /// <summary>
    /// 腾讯地图解析插件
    /// </summary>
    public class AndroidTencentMapDataParser : AbstractDataParsePlugin
    {
        public override IPluginInfo PluginInfo { get; set; }

        public AndroidTencentMapDataParser()
        {
            DataParsePluginInfo pluginInfo = new DataParsePluginInfo();
            pluginInfo.Guid = "{A222D040-78C6-490A-9142-D4651C0BA18B}";
            pluginInfo.Name = "腾讯地图";
            pluginInfo.Group = "地图公交";
            pluginInfo.DeviceOSType = EnumOSType.Android;
            pluginInfo.VersionStr = "0.0";
            pluginInfo.Pump = EnumPump.USB | EnumPump.Mirror;
            pluginInfo.GroupIndex = 6;
            pluginInfo.OrderIndex = 0;

            pluginInfo.AppName = "com.tencent.map";
            pluginInfo.Icon = "\\icons\\TencentMap.png";
            pluginInfo.Description = "提取安卓设备腾讯地图信息";
            pluginInfo.SourcePath = new SourceFileItems();
            pluginInfo.SourcePath.AddItem("/data/data/com.tencent.map/databases/#F");
            pluginInfo.SourcePath.AddItem("/data/data/com.tencent.map/shared_prefs/#F");
            pluginInfo.SourcePath.AddItem("/data/data/com.tencent.map/files/#F");

            PluginInfo = pluginInfo;
        }

        public override object Execute(object arg, IAsyncTaskProgress progress)
        {
            TreeDataSource ds = new TreeDataSource();

            try
            {
                var pi = PluginInfo as DataParsePluginInfo;
                var databasesPath = pi.SourcePath[0].Local;

                if (!FileHelper.IsValidDictory(databasesPath))
                {
                    return ds;
                }
            }
            catch
            {//TODO:异常处理

            }
            finally
            {
                ds?.BuildParent();
            }

            return ds;
        }
    }
}
