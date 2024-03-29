using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Infrastructure.Data.Models.MssqlModels;

namespace TouristAgency.Infrastructure.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(new Hotel[]
            {
                new Hotel()
                {
                    Id = 1,
                    Name = "Airotel Galaxy",
                    Location = "El. Venizelou 27, Kavala 653 02, Гърция",
                    UnorganizedOfferId = 1
                },
                new Hotel()
                {
                    Id = 2,
                    Name = "Oceanis Hotel",
                    Location = "Erithrou Stavrou 32, Kavala 654 03, Гърция",
                    UnorganizedOfferId = 1
                },
                new Hotel()
                {
                    Id = 3,
                    Name = "Esperia Hotel",
                    Location = "Erithrou Stavrou 44, Kavala 654 03, Гърция",
                    UnorganizedOfferId = 1
                },
                new Hotel()
                {
                    Id = 4,
                    Name = "Kiani Beach Resort Family All Inclusive",
                    Location = "Kalami, Kiani Beach, Kalives 730 03, Гърция",
                    UnorganizedOfferId = 2
                },
                new Hotel()
                {
                    Id = 5,
                    Name = "Peninsula Resort & Spa",
                    Location = "Peninsula Hotel, Agia Pelagia, Iraklio 715 00, Гърция",
                    UnorganizedOfferId = 2
                },
                new Hotel()
                {
                    Id = 6,
                    Name = "Stella Island Luxury Resort & Spa",
                    Location = "stella island, Analipsi 700 14, Гърция",
                    UnorganizedOfferId = 2
                },
                new Hotel()
                {
                    Id = 7,
                    Name = "Mylos Mountain Villas",
                    Location = "Epar.Od. Lefkas - Kato Exanthias, Lefkada 310 80, Гърция",
                    UnorganizedOfferId = 3
                },
                new Hotel()
                {
                    Id = 8,
                    Name = "Ponti Beach Hotel",
                    Location = "Beach of Ponti Vasiliki, Lefkada 310 82, Гърция",
                    UnorganizedOfferId = 3
                },
                new Hotel()
                {
                    Id = 9,
                    Name = "Santa Marina Hotel",
                    Location = "ag.nikitas, Lefkada 310 80, Гърция",
                    UnorganizedOfferId = 3
                },
                new Hotel()
                {
                    Id = 10,
                    Name = "Atoli Studios",
                    Location = "Unnamed Road, Skala Marion 640 02, Гърция",
                    UnorganizedOfferId = 4
                },
                new Hotel()
                {
                    Id = 11,
                    Name = "Anassa Blue Boutique Hotel",
                    Location = "Thasou, Limenas Thassos 640 04, Гърция",
                    UnorganizedOfferId = 4
                },
                new Hotel()
                {
                    Id = 12,
                    Name = "Elektra Comfort Hotel",
                    Location = "Skala, Prinos 640 10, Гърция",
                    UnorganizedOfferId = 4
                },
                new Hotel()
                {
                    Id = 13,
                    Name = "Babuino house",
                    Location = "Via del Babuino, 148, 00187 Roma RM, Италия",
                    UnorganizedOfferId = 5
                },
                new Hotel()
                {
                    Id = 14,
                    Name = "Seven Miracles Inn",
                    Location = "Via di S. Croce in Gerusalemme, 83, 00185 Roma RM, Италия",
                    UnorganizedOfferId = 5
                },
                new Hotel()
                {
                    Id = 15,
                    Name = "Agnes Roma",
                    Location = "Viale Gorizia, 14, 00198 Roma RM, Италия",
                    UnorganizedOfferId = 5
                },
                new Hotel()
                {
                    Id = 16,
                    Name = "VOI Marsa Siclà Essentia",
                    Location = "Contrada Samuele, snc, 97018 Sampieri RG, Италия",
                    UnorganizedOfferId = 6
                },
                new Hotel()
                {
                    Id = 17,
                    Name = "La Casa del Ducato",
                    Location = "Via Migliaro, 4, 90011 Bagheria PA, Италия",
                    UnorganizedOfferId = 6
                },
                new Hotel()
                {
                    Id = 18,
                    Name = "ADLER Spa Resort SICILIA",
                    Location = "Contrada Salsa, 92010 Siculiana AG, Италия",
                    UnorganizedOfferId = 6
                },
                new Hotel()
                {
                    Id = 19,
                    Name = "Sighientu Resort",
                    Location = "Via Serchio, 139, 09045 Quartu Sant'Elena CA, Италия",
                    UnorganizedOfferId = 7
                },
                new Hotel()
                {
                    Id = 20,
                    Name = "Le Tre Querce",
                    Location = "Via Li Fureddi, 20, 07052 San Teodoro SS, Италия",
                    UnorganizedOfferId = 7
                },
                new Hotel()
                {
                    Id = 21,
                    Name = "Residence Hotel La Pelosetta",
                    Location = "Viale la Pelosa, 35, 07040 Stintino SS, Италия",
                    UnorganizedOfferId = 7
                },
                new Hotel()
                {
                    Id = 22,
                    Name = "Grand T1 proche Promenade des Anglais",
                    Location = "Ница, Франция",
                    UnorganizedOfferId = 8
                },
                new Hotel()
                {
                    Id = 23,
                    Name = "Residence Share Inn",
                    Location = "21 Rue Massena, 06000 Nice, Франция",
                    UnorganizedOfferId = 8
                },
                new Hotel()
                {
                    Id = 24,
                    Name = "Hôtel Mercure Nice Promenade des Anglais",
                    Location = "2 Rue Halévy, 06000 Nice, Франция",
                    UnorganizedOfferId = 8
                },
                new Hotel()
                {
                    Id = 25,
                    Name = "FINESTATE Coliving Champs-Elysées",
                    Location = "25 Rue Washington Finestate, 75008 Paris, Франция",
                    UnorganizedOfferId = 9
                },
                new Hotel()
                {
                    Id = 26,
                    Name = "Hotel des Carmes by Malone",
                    Location = "5 Rue des Carmes, 75005 Paris, Франция",
                    UnorganizedOfferId = 9
                },
                new Hotel()
                {
                    Id = 27,
                    Name = "Domitys L'Ellipse",
                    Location = "122-126 Rue du Château des Rentiers, 75013 Paris, Франция",
                    UnorganizedOfferId = 9
                },
                new Hotel()
                {
                    Id = 28,
                    Name = "Motel One Barcelona-Ciutadella",
                    Location = "Pg. de Pujades, 11-13, Sant Martí, 08018 Barcelona, Испания",
                    UnorganizedOfferId = 10
                },
                new Hotel()
                {
                    Id = 29,
                    Name = "Acta Voraport",
                    Location = "C/ de Ramon Turró, 169, B, Sant Martí, 08005 Barcelona, Испания",
                    UnorganizedOfferId = 10
                },
                new Hotel()
                {
                    Id = 30,
                    Name = "Tembo Barcelona",
                    Location = "479-487, Carrer de Ramon Llull, 08930 Barcelona, Испания",
                    UnorganizedOfferId = 10
                },
                new Hotel()
                {
                    Id = 31,
                    Name = "AluaSun Doblemar",
                    Location = "Gran Vía de la Manga, 30380 La Manga, Murcia, Испания",
                    UnorganizedOfferId = 11
                },
                new Hotel()
                {
                    Id = 32,
                    Name = "Hotel Izán Cavanna",
                    Location = "Pl. del Cavanna, s/n, 30380 La Manga, Murcia, Испания",
                    UnorganizedOfferId = 11
                },
                new Hotel()
                {
                    Id = 33,
                    Name = "Hotel Los Delfines",
                    Location = "Gran Vía de la Manga, s/n, Km. 1,4, 30380 La Manga, Murcia, Испания",
                    UnorganizedOfferId = 11
                },
                new Hotel()
                {
                    Id = 34,
                    Name = "Port Benidorm Hotel & Spa 4* Sup",
                    Location = "Av. de Estocolmo, 4, 03503 Benidorm, Alicante, Испания",
                    UnorganizedOfferId = 12
                },
                new Hotel()
                {
                    Id = 35,
                    Name = "Port Alicante City & Beach",
                    Location = "Av de Cataluña, 20, 03540 Alicante, Испания",
                    UnorganizedOfferId = 12
                },
                new Hotel()
                {
                    Id = 36,
                    Name = "AJ Gran Alacant by SH Hoteles",
                    Location = "Avenida Finlandia, 15 Urb, 03130 Gran Alacant, Alicante, Испания",
                    UnorganizedOfferId = 12
                },
                new Hotel()
                {
                    Id = 37,
                    Name = "Mercure Benidorm",
                    Location = "Av. de Panamá, 5, 03502 Benidorm, Alicante, Испания",
                    UnorganizedOfferId = 13
                },
                new Hotel()
                {
                    Id = 38,
                    Name = "Hotel Cimbel",
                    Location = "Av. de Europa, 1, 03503 Benidorm, Alicante, Испания",
                    UnorganizedOfferId = 13
                },
                new Hotel()
                {
                    Id = 39,
                    Name = "Ambassador Playa II",
                    Location = "C. Gerona, 39, 41, 03503 Benidorm, Alicante, Испания",
                    UnorganizedOfferId = 13
                },
                new Hotel()
                {
                    Id = 40,
                    Name = "Toprak Otel",
                    Location = "Kızıltoprak, 978. Sk No.14, 07300 Muratpaşa/Antalya, Турция",
                    UnorganizedOfferId = 14
                },
                new Hotel()
                {
                    Id = 41,
                    Name = "Lupo Libero Hotel Spa",
                    Location = "Tahılpazarı, 462. Sk. NO:2, 07040 Muratpaşa/Antalya, Турция",
                    UnorganizedOfferId = 14
                },
                new Hotel()
                {
                    Id = 42,
                    Name = "La Paloma Hotel",
                    Location = "Yıldız, 244. Sk. No:84 D:97, 07050 Muratpaşa/Antalya, Турция",
                    UnorganizedOfferId = 14
                },
                new Hotel()
                {
                    Id = 43,
                    Name = "Eliada Hotel",
                    Location = "Camiatik, Aslanlar Cd. no:1, 09400 Kuşadası/Aydın, Турция",
                    UnorganizedOfferId = 15
                },
                new Hotel()
                {
                    Id = 44,
                    Name = "Ilayda Avantgarde Hotel",
                    Location = "Türkmen, Atatürk Blv. No:42, 09400 Kuşadası/Aydın, Турция",
                    UnorganizedOfferId = 15
                },
                new Hotel()
                {
                    Id = 45,
                    Name = "Charisma De Luxe Hotel",
                    Location = "Türkmen, Gazi Beğendi Sk. No:7, 09400 Kuşadası/Aydın, Турция",
                    UnorganizedOfferId = 15
                },
                new Hotel()
                {
                    Id = 46,
                    Name = "Smart Stay Beach Bodrum - All Inclusive",
                    Location = "Gümbet, 1510. Sk. No:8, 48400 Bodrum/Muğla, Турция",
                    UnorganizedOfferId = 16
                },
                new Hotel()
                {
                    Id = 47,
                    Name = "Hotel Ambrosia",
                    Location = "Hacıahmetler Mevkii Bitez, Pomelan Cd. No:32, 48470 Bodrum/Muğla, Турция",
                    UnorganizedOfferId = 16
                },
                new Hotel()
                {
                    Id = 48,
                    Name = "Degirmenburnu Residence",
                    Location = "Eskiçeşme, Eskiçeşme Mahallesi Osman Nuri Bilgin Caddesi, Haremtan Sk. No: 48, 48400 Bodrum/Muğla, Турция",
                    UnorganizedOfferId = 16
                },
                new Hotel()
                {
                    Id = 49,
                    Name = "Grand Yayla Hotel",
                    Location = "Sakarya, 3100. Sk. No:1, 35930 Çeşme/İzmir, Турция",
                    UnorganizedOfferId = 17
                },
                new Hotel()
                {
                    Id = 50,
                    Name = "Amber Boutique Hotel",
                    Location = "İsmet İnönü, 2032. Sk. No:32, 35930 Çeşme/İzmir, Турция",
                    UnorganizedOfferId = 17
                },
                new Hotel()
                {
                    Id = 51,
                    Name = "Bayram Hotel",
                    Location = "16 Eylül, 3011. Sk. 37/A, 35930 Çeşme/İzmir, Турция",
                    UnorganizedOfferId = 17
                },
                new Hotel()
                {
                    Id = 52,
                    Name = "Oscar Concept Apartments",
                    Location = "Av. Óscar Monteiro Torres 39, 1000-220 Lisboa, Португалия",
                    UnorganizedOfferId = 18
                },
                new Hotel()
                {
                    Id = 53,
                    Name = "Ramada by Wyndham Lisbon",
                    Location = "Av. Eng. Arantes e Oliveira 9, 1900-221 Lisboa, Португалия",
                    UnorganizedOfferId = 18
                },
                new Hotel()
                {
                    Id = 54,
                    Name = "VIP Executive Picoas Hotel",
                    Location = "R. Filipe Folque 12, 1069-191 Lisboa, Португалия",
                    UnorganizedOfferId = 18
                },
                new Hotel()
                {
                    Id = 55,
                    Name = "Luxury Family Hotel Bílá Labuť",
                    Location = "Biskupská 1347, 110 00 Petrská čtvrť, Чехия",
                    UnorganizedOfferId = 19
                },
                new Hotel()
                {
                    Id = 56,
                    Name = "Hotel Duo",
                    Location = "Teplická 492, 190 00 Praha 9, Чехия",
                    UnorganizedOfferId = 19
                },
                new Hotel()
                {
                    Id = 57,
                    Name = "Hotel Ariston",
                    Location = "65, Seifertova 615, Žižkov, 130 00 Praha 3, Чехия",
                    UnorganizedOfferId = 19
                },
                new Hotel()
                {
                    Id = 58,
                    Name = "Huinid Obelisco Hotel",
                    Location = "Sarmiento 1431, C1042 Cdad. Autónoma de Buenos Aires, Аржентина",
                    UnorganizedOfferId = 20
                },
                new Hotel()
                {
                    Id = 59,
                    Name = "HTL Urbano",
                    Location = "Tucumán 451, C1049 Cdad. Autónoma de Buenos Aires, Аржентина",
                    UnorganizedOfferId = 20
                },
                new Hotel()
                {
                    Id = 60,
                    Name = "Grand King Hotel",
                    Location = "Lavalle 560, C1047 AAL, Cdad. Autónoma de Buenos Aires, Аржентина",
                    UnorganizedOfferId = 20
                },
                new Hotel()
                {
                    Id = 61,
                    Name = "Hotel Meliá Habana",
                    Location = "4H54+GW5, Avenida 3ra, La Habana 11300, Куба",
                    UnorganizedOfferId = 21
                },
                new Hotel()
                {
                    Id = 62,
                    Name = "Gran Hotel Manzana Kempinski La Habana",
                    Location = "4JQR+5VG, Calle San Rafael (entre Monserrate y, Agramonte, La Habana 10100, Куба",
                    UnorganizedOfferId = 21
                },
                new Hotel()
                {
                    Id = 63,
                    Name = "Iberostar Parque Central",
                    Location = "267 Agramonte, La Habana, Куба",
                    UnorganizedOfferId = 21
                },
                new Hotel()
                {
                    Id = 64,
                    Name = "Casa Pachacamac",
                    Location = "Q4H9+F2X, Ferrocarril, Lima 15823, Перу",
                    UnorganizedOfferId = 22
                },
                new Hotel()
                {
                    Id = 65,
                    Name = "Amazing Casa Wynwood in Barranco",
                    Location = "Jr, Jiron Martinez de Pinillos 270, Barranco 15063, Перу",
                    UnorganizedOfferId = 22
                },
                new Hotel()
                {
                    Id = 66,
                    Name = "DoubleTree by Hilton Lima Miraflores El Pardo",
                    Location = "Jr. Independencia 141, Lima 15074, Перу",
                    UnorganizedOfferId = 22
                },
                new Hotel()
                {
                    Id = 67,
                    Name = "Hotel Atlântico Business Centro",
                    Location = "R. Sen. Dantas, 25 - Centro, Rio de Janeiro - RJ, 20031-202, Бразилия",
                    UnorganizedOfferId = 23
                },
                new Hotel()
                {
                    Id = 68,
                    Name = "Hotel Atlantico Prime",
                    Location = "R. do Rezende, 87 - Centro, Rio de Janeiro - RJ, 20231-091, Бразилия",
                    UnorganizedOfferId = 23
                },
                new Hotel()
                {
                    Id = 69,
                    Name = "Hotéis OK",
                    Location = "R. Sen. Dantas, 24 - Centro, Rio de Janeiro - RJ, 20031-200, Бразилия",
                    UnorganizedOfferId = 23
                },
                new Hotel()
                {
                    Id = 70,
                    Name = "plat hostel keikyu minowa forest",
                    Location = "3 Chome-39-5 Ryusen, Taito City, Tokyo 110-0012, Япония",
                    UnorganizedOfferId = 24
                },
                new Hotel()
                {
                    Id = 71,
                    Name = "Belken Hotel Kanda",
                    Location = "Япония, 〒101-0041 Tokyo, Chiyoda City, Kanda Sudacho, 1 Chome−4−7 ベルケンホテル神田",
                    UnorganizedOfferId = 24
                },
                new Hotel()
                {
                    Id = 72,
                    Name = "Tabata Oji Hotel",
                    Location = "2 Chome-9-1 Tabatashinmachi, Kita City, Tokyo 114-0012, Япония",
                    UnorganizedOfferId = 24
                },
                new Hotel()
                {
                    Id = 73,
                    Name = "Imu Hotel Kyoto",
                    Location = "411 Iwatoyamacho, Shimogyo Ward, Kyoto, 600-8445, Япония",
                    UnorganizedOfferId = 25
                },
                new Hotel()
                {
                    Id = 74,
                    Name = "Hotel Doria Kyoto Karasuma Gojo",
                    Location = "240 Odawaracho, Shimogyo Ward, Kyoto, 600-8430, Япония",
                    UnorganizedOfferId = 25
                },
                new Hotel()
                {
                    Id = 75,
                    Name = "West Japan Kyoto Kiyomizu",
                    Location = "Япония, 〒605-0856 Kyoto, Higashiyama Ward, Atarashicho, 133番地 ・134番地 3",
                    UnorganizedOfferId = 25
                },
                new Hotel()
                {
                    Id = 76,
                    Name = "Kandy Hills",
                    Location = "84 Rajapihilla Mawatha, Kandy 20000, Шри Ланка",
                    UnorganizedOfferId = 26
                },
                new Hotel()
                {
                    Id = 77,
                    Name = "Rivora Heights",
                    Location = "34 Rajapihilla Mawatha, Kandy 20000, Шри Ланка",
                    UnorganizedOfferId = 26
                },
                new Hotel()
                {
                    Id = 78,
                    Name = "Lakewood Residence",
                    Location = "39/3 Rajapihilla Mawatha, Kandy 20000, Шри Ланка",
                    UnorganizedOfferId = 26
                },
                new Hotel()
                {
                    Id = 79,
                    Name = "Holiday Inn Express Beijing Dongzhimen, an IHG Hotel",
                    Location = "WCQR+RXF, Dongcheng, Beijing, Китай, 100007",
                    UnorganizedOfferId = 27
                },
                new Hotel()
                {
                    Id = 80,
                    Name = "Sunworld Hotel Wangfujing",
                    Location = "Китай, Beijing, Dongcheng, 东单灯市口大街88号 邮政编码: 100006",
                    UnorganizedOfferId = 27
                },
                new Hotel()
                {
                    Id = 81,
                    Name = "Howard Johnson Paragon Hotel Beijing",
                    Location = "Китай, Beijing, Dongcheng, 建国门内大街建国门内大街甲18号 邮政编码: 100005",
                    UnorganizedOfferId = 27
                },
                new Hotel()
                {
                    Id = 82,
                    Name = "Citadines Rochor",
                    Location = "2 Serangoon Rd, #03-01, Сингапур 218227",
                    UnorganizedOfferId = 28
                },
                new Hotel()
                {
                    Id = 83,
                    Name = "Mercure ICON Singapore City Centre",
                    Location = "8 Club St, Сингапур 069472",
                    UnorganizedOfferId = 28
                },
                new Hotel()
                {
                    Id = 84,
                    Name = "Hotel Boss",
                    Location = "500 Jln Sultan, Сингапур 199020",
                    UnorganizedOfferId = 28
                },
                new Hotel()
                {
                    Id = 85,
                    Name = "Local Paradise Rasdhoo",
                    Location = "Rozemead Goalhi, Rasdhoo, Малдиви",
                    UnorganizedOfferId = 29
                },
                new Hotel()
                {
                    Id = 86,
                    Name = "Beach Cottage",
                    Location = "A.A Villanufannu Magu, Rasdhoo 09020, Малдиви",
                    UnorganizedOfferId = 29
                },
                new Hotel()
                {
                    Id = 87,
                    Name = "Villa Nautica, Maldives",
                    Location = "Lankanfinolhu, 08420, Малдиви",
                    UnorganizedOfferId = 29
                },
                new Hotel()
                {
                    Id = 88,
                    Name = "Pickalbatros Blu Spa Resort - Adults Friendly 16 Years Plus- Ultra All-Inclusive",
                    Location = "Mamsha Road (The Corniche St, Hurghada, Red Sea Governorate 84517, Египет",
                    UnorganizedOfferId = 30
                },
                new Hotel()
                {
                    Id = 89,
                    Name = "Moon beach resort",
                    Location = "El-Nasr, Hurghada 2, Red Sea Governorate 1972703, Египет",
                    UnorganizedOfferId = 30
                },
                new Hotel()
                {
                    Id = 90,
                    Name = "Redcon Suites",
                    Location = "Hurghada, Red Sea Governorate 1964413, Египет",
                    UnorganizedOfferId = 30
                },
                new Hotel()
                {
                    Id = 91,
                    Name = "Casa Cook El Gouna",
                    Location = "CMF9+93, Kite center, street, Hurghada 2, Red Sea Governorate 84513, Египет",
                    UnorganizedOfferId = 31
                },
                new Hotel()
                {
                    Id = 92,
                    Name = "The Chedi El Gouna",
                    Location = "Hill Villas Rd, Hurghada 2, Red Sea Governorate 84513, Египет",
                    UnorganizedOfferId = 31
                },
                new Hotel()
                {
                    Id = 93,
                    Name = "Club Paradisio El Gouna - Red Sea",
                    Location = "Between Phases 1 & 2, 84513, Red Sea Governorate, Египет",
                    UnorganizedOfferId = 31
                },
                new Hotel()
                {
                    Id = 94,
                    Name = "Siva Golden Bay Makadi",
                    Location = "XW99+7QF طريق الغردقة, Red Sea Governorate, Египет",
                    UnorganizedOfferId = 32
                },
                new Hotel()
                {
                    Id = 95,
                    Name = "Tia Heights Makadi Bay",
                    Location = "Hurghada 1, Ал Бахр ал Ахмар 1960510, Египет",
                    UnorganizedOfferId = 32
                },
                new Hotel()
                {
                    Id = 96,
                    Name = "Stella Makadi Hotels & Resorts",
                    Location = "Km 32 طريق الغردقة - سفاجا, Hurghada 1, Red Sea Governorate 84945, Египет",
                    UnorganizedOfferId = 32
                },
                new Hotel()
                {
                    Id = 97,
                    Name = "Selina Agafay Nomad Camp",
                    Location = "Route des Camps Désert, Agafay 40272, Мароко",
                    UnorganizedOfferId = 33
                },
                new Hotel()
                {
                    Id = 98,
                    Name = "Auberge Le Festival Todra Gorge",
                    Location = "Tinghir, Мароко",
                    UnorganizedOfferId = 33
                },
                new Hotel()
                {
                    Id = 99,
                    Name = "Kenzi Rissani",
                    Location = "n, 13 Rue fath, Errachidia 52000, Мароко",
                    UnorganizedOfferId = 33
                },
                new Hotel()
                {
                    Id = 100,
                    Name = "Dar Yasmine Djerba",
                    Location = "BP467, 4116, Тунис",
                    UnorganizedOfferId = 34
                },
                new Hotel()
                {
                    Id = 101,
                    Name = "Iberostar Mehari Djerba",
                    Location = "Route Touristique Midoun Djerba, Djerba 4116, Тунис",
                    UnorganizedOfferId = 34
                },
                new Hotel()
                {
                    Id = 102,
                    Name = "Radisson Blu Palace Resort & Thalasso, Djerba",
                    Location = "Houmt Souk 4128, Тунис",
                    UnorganizedOfferId = 34
                },
                new Hotel()
                {
                    Id = 103,
                    Name = "Hôtel Suisse Tunis",
                    Location = "Q5XH+2MF, Rue de Suisse, Tunis, Тунис",
                    UnorganizedOfferId = 35
                },
                new Hotel()
                {
                    Id = 104,
                    Name = "Palais Bayram",
                    Location = "Gouvernorat de, 6 Rue des Andalous, Tunis 1008, Тунис",
                    UnorganizedOfferId = 35
                },
                new Hotel()
                {
                    Id = 105,
                    Name = "El Oumara Hotel",
                    Location = "Tunis, Тунис",
                    UnorganizedOfferId = 35
                },
            });
        }
    }
}
