﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BiliBiliTool.Apiquery
{
    public class ApiList
    {
        /// <summary>
        /// 登录
        /// </summary>
        public static String LOGIN = "https://api.bilibili.com/x/web-interface/nav";

        /// <summary>
        /// 每日任务完成情况
        /// </summary>
        public static String reward = "https://api.bilibili.com/x/member/web/exp/reward";

        /// <summary>
        /// 获取某分区下的视频排行
        /// </summary>
        public static String getRegionRanking = "https://api.bilibili.com/x/web-interface/ranking/region";

        /// <summary>
        /// 上报观看进度
        /// </summary>
        public static String videoHeartbeat = "https://api.bilibili.com/x/click-interface/web/heartbeat";

        /// <summary>
        /// 分享视频
        /// </summary>
        public static String AvShare = "https://api.bilibili.com/x/web-interface/share/add";

        /// <summary>
        /// 漫画签到
        /// </summary>
        public static String Manga = "https://manga.bilibili.com/twirp/activity.v1.Activity/ClockIn";

        /// <summary>
        /// 查询已经通过投币获取到的经验值
        /// </summary>
        public static String needCoin = "https://www.bilibili.com/plus/account/exp.php";

        public static String ServerPush = "https://sc.ftqq.com/";
        public static String CoinAdd = "https://api.bilibili.com/x/web-interface/coin/add";
        public static String isCoin = "https://api.bilibili.com/x/web-interface/archive/coins";



        /**
         * 硬币换银瓜子
         */
        public static String silver2coin = "https://api.live.bilibili.com/pay/v1/Exchange/silver2coin";

        /**
         * 查询银瓜子兑换状态
         */
        public static String getSilver2coinStatus = "https://api.live.bilibili.com/pay/v1/Exchange/getStatus";



        /**
         * 查询主站硬币余额
         */
        public static String getCoinBalance = "https://account.bilibili.com/site/getCoin";

        /**
         * 充电请求
         */
        public static String autoCharge = "https://api.bilibili.com/x/ugcpay/trade/elec/pay/quick";

        /**
         * 充电留言
         */
        public static String chargeComment = "https://api.bilibili.com/x/ugcpay/trade/elec/message";

        /**
         * 领取大会员福利
         */
        public static String vipPrivilegeReceive = "https://api.bilibili.com/x/vip/privilege/receive";

        /**
         * 领取大会员漫画福利
         */
        public static String mangaGetVipReward = "https://manga.bilibili.com/twirp/user.v1.User/GetVipReward";
        /**
         * 直播签到
         */
        public static String liveCheckin = "https://api.live.bilibili.com/xlive/web-ucenter/v1/sign/DoSign";
    }

}
