﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDanMuLib
{
    internal class ApiUrls
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        public const string UserInfo = "https://api.bilibili.com/x/space/acc/info?mid=";


        /// <summary>
        /// 用户直播地址
        /// </summary>
        public const string BroadCastUrl = "https://api.live.bilibili.com/room/v1/Danmu/getConf?room_id=";


        /// <summary>
        /// 表情包地址
        /// </summary>
        /// <remarks>
        /// 需要登录
        /// </remarks>
        public const string EmoteUrl = "https://api.bilibili.com/x/emote/setting/panel?business=reply";
    }
}
