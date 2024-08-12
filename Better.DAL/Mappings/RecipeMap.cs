using Better.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better.DAL.Mappings
{
    public class RecipeMap : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.Property(p => p.Title).HasMaxLength(100);
            builder.Property(p => p.Preparation).HasMaxLength(1000);

            builder.HasData(new Recipe
            {
                Id = Guid.NewGuid(),
                Title = "Ödem Attırıcı Smoothie",
                Materials = "\r\n1 salatalık\r\n1/2 (yarım) yeşil elma\r\n1/4 (çeyrek) bağ kadar maydanoz\r\n1 dal nane\r\n1 bardak su",
                Preparation ="Bütün malzemeleri blender ya da shaker'dan geçirin. Afiyet Olsun :)",
                CategoryId = Guid.Parse("DAA90872-2B2E-474C-A464-4B0009DFBE0B"),
                ImageId = Guid.Parse("C600EF28-DE70-45D8-8689-2ACE26134F37"),



              

                
            },
            new Recipe
            {
                Id = Guid.NewGuid(),

                Title = "Protein Yüksek Atıştırmalık",
                Materials = "\r\n1 su bardağı yulaf ezmesi\r\n\r\n2 yemek kaşığı bal\r\n\r\n1 yemek kaşığı chia tohumu\r\n\r\n2 yemek kaşığı keten tohumu\r\n\r\n1 çay kaşığı Hindistan cevizi yağı\r\n\r\n1 çay bardağı karışık kuru yemiş\r\n\r\n2 yemek kaşığı fıstık ezmesi\r\n\r\n1 tatlı kaşığı tarçın",
                Preparation = "İlk olarak geniş bir kap almalısın. Ardından tüm malzemeleri sırayla bu kabın içine dök.\r\n\r\nMalzemeleri homojen bir kıvam alıncaya kadar karıştır.\r\n\r\nTüm malzemeler bir homojen bir kıvama geldikten sonra bir tepsiye yağlı kağıt ser ve hazırlamış olduğun karışımı bu kağıdın üstüne yay.\r\n\r\nKarışım tepsi içerisinde dümdüz bir hal almasını sağla ve karışımı ortalama 20 dk. kadar buzdolabında beklet.\r\n\r\n20 dk. sonunda hazırlamış olduğun barını dilediğin boyutlarda parçalara ayıracak şekilde keserek tüketebilirsin.\r\n",
                CategoryId = Guid.Parse("786214DC-4B54-4438-A673-412A43F62331"),
                ImageId = Guid.Parse("35BDB1A3-C402-4A7E-910C-5B7B2E79E486"),

               
            }
            

            );
        }
    }
}
