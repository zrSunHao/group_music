using Hao.GroupMusic.App.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hao.GroupMusic.App.Business.ViewModels
{
    public class SearchPageViewModel
    {
        public List<ItemModel> Songs => new List<ItemModel>()
        {
            new ItemModel(){Index = 1, Key = "曾经的你",Value = "card_1.png",Intro = "许巍"},
            new ItemModel(){Index = 2, Key = "记事本",Value = "card_2.png",Intro = "陈慧琳"},
            new ItemModel(){Index = 3, Key = "我会好好的",Value = "card_3.png",Intro = "王心凌"},
            new ItemModel(){Index = 4, Key = "爱是你我",Value = "card_4.png",Intro = "刀郎&云朵&王翰仪"},
            new ItemModel(){Index = 5, Key = "江南",Value = "card_5.png",Intro = "林俊杰"},
            new ItemModel(){Index = 6, Key = "黄昏",Value = "card_6.png",Intro = "周传雄"},
            new ItemModel(){Index = 7, Key = "Honey",Value = "card_7.png",Intro = "王心凌"},
            new ItemModel(){Index = 8, Key = "寂寞沙洲冷",Value = "card_8.png",Intro = "周传雄"},
            new ItemModel(){Index = 9, Key = "此生不换",Value = "card_9.png",Intro = "青鸟飞鱼"},
            new ItemModel(){Index = 10, Key = "隐形的翅膀",Value = "card_10.png",Intro = "张韶涵"},
            new ItemModel(){Index = 11, Key = "后来",Value = "card_11.png",Intro = "刘若英"},
            new ItemModel(){Index = 12, Key = "红色高跟鞋",Value = "card_12.png",Intro = "蔡健雅"},
            new ItemModel(){Index = 13, Key = "我们的爱",Value = "card_13.png",Intro = "F.I.R飞儿乐队"},
            new ItemModel(){Index = 14, Key = "蓝莲花",Value = "card_1.png",Intro = "许巍"},
            new ItemModel(){Index = 15, Key = "Super Star",Value = "card_2.png",Intro = "S.H.E"},
            new ItemModel(){Index = 16, Key = "奢香夫人",Value = "card_3.png",Intro = "凤凰传奇"},
        };

        public List<ItemModel> CollectList => new List<ItemModel>(){
            new ItemModel() { Key = "轻音乐", Value = "card_5.png" },
            new ItemModel() { Key = "英语", Value = "card_6.png" },
            new ItemModel() { Key = "日语", Value = "card_7.png" },
            new ItemModel() { Key = "90后", Value = "card_8.png" },
            new ItemModel() { Key = "00后", Value = "card_9.png" },
            new ItemModel() { Key = "古风", Value = "card_10.png" },
            new ItemModel() { Key = "武侠影视剧", Value = "card_11.png" },
        };
    }
}
