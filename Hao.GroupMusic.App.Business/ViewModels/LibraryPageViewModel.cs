using Hao.GroupMusic.App.Business.Models;

namespace Hao.GroupMusic.App.Business.ViewModels
{
    public class LibraryPageViewModel
    {
        public string Name { get; set; } = "LibraryPageViewModel";

        public List<ItemModel> RecommendList => new List<ItemModel>() {
            new ItemModel() { Key = "新歌推荐", Value = "card_1.png" },
            new ItemModel() { Key = "今日推荐", Value = "card_2.png" },
            new ItemModel() { Key = "热歌推荐", Value = "card_3.png" },
            new ItemModel() { Key = "私人电台", Value = "card_4.png" }, 
        };

        public List<ItemModel> CategoryList => new List<ItemModel>(){
            new ItemModel() { Key = "轻音乐", Value = "card_5.png" },
            new ItemModel() { Key = "英语", Value = "card_6.png" },
            new ItemModel() { Key = "日语", Value = "card_7.png" },
            new ItemModel() { Key = "90后", Value = "card_8.png" },
            new ItemModel() { Key = "00后", Value = "card_9.png" },
            new ItemModel() { Key = "古风", Value = "card_10.png" },
            new ItemModel() { Key = "武侠影视剧", Value = "card_11.png" },
        };

        public List<ItemModel> AuthorList => new List<ItemModel>(){
            new ItemModel() { Key = "伍佰", Value = "people_1.png" },
            new ItemModel() { Key = "梁静茹", Value = "people_2.png" },
            new ItemModel() { Key = "周杰伦", Value = "people_3.png" },
            new ItemModel() { Key = "许嵩", Value = "people_4.png" },
            new ItemModel() { Key = "林俊杰", Value = "people_5.png" },
            new ItemModel() { Key = "王心凌", Value = "people_6.png" },
            new ItemModel() { Key = "郁可唯", Value = "people_7.png" },
            new ItemModel() { Key = "蔡健雅", Value = "people_8.png" },
        };

        public List<ItemModel> ShareList => new List<ItemModel>(){
            new ItemModel() { Key = "zhangsan", Value = "card_12.png" },
            new ItemModel() { Key = "lisi", Value = "card_13.png" },
            new ItemModel() { Key = "wangwu", Value = "card_14.png" },
            new ItemModel() { Key = "laoliu", Value = "card_1.png" },
            new ItemModel() { Key = "sunwukong", Value = "card_2.png" },
            new ItemModel() { Key = "zhubajie", Value = "card_3.png" },
        };
    }
}
