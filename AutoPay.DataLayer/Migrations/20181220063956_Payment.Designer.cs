﻿// <auto-generated />
using System;
using AutoPay.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoPay.DataLayer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181220063956_Payment")]
    partial class Payment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoPay.Entities.Batch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("CustomersCount");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("SqlQuery")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.Property<int>("Status");

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnName("FK_AspNetUsers")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("Batches");
                });

            modelBuilder.Entity("AutoPay.Entities.BatchCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AmountDue")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int>("BatchId")
                        .HasColumnName("FK_Batches");

                    b.Property<string>("CustomerId")
                        .HasMaxLength(256);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(512);

                    b.Property<string>("IsExistsInLocalDb")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("BatchId");

                    b.ToTable("BatchCustomers");
                });

            modelBuilder.Entity("AutoPay.Entities.Country", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Code")
                        .HasMaxLength(8);

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<int>("Order");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new { Id = 1, Code = "AD", Name = "Andorra", Order = 1 },
                        new { Id = 2, Code = "AE", Name = "United Arab Emirates", Order = 1 },
                        new { Id = 3, Code = "AF", Name = "Afghanistan", Order = 1 },
                        new { Id = 4, Code = "AG", Name = "Antigua and Barbuda", Order = 1 },
                        new { Id = 5, Code = "AI", Name = "Anguilla", Order = 1 },
                        new { Id = 6, Code = "AL", Name = "Albania", Order = 1 },
                        new { Id = 7, Code = "AM", Name = "Armenia", Order = 1 },
                        new { Id = 8, Code = "AN", Name = "Netherlands Antilles", Order = 1 },
                        new { Id = 9, Code = "AO", Name = "Angola", Order = 1 },
                        new { Id = 10, Code = "AQ", Name = "Antarctica", Order = 1 },
                        new { Id = 11, Code = "AR", Name = "Argentina", Order = 1 },
                        new { Id = 12, Code = "AS", Name = "American Samoa", Order = 1 },
                        new { Id = 13, Code = "AT", Name = "Austria", Order = 1 },
                        new { Id = 14, Code = "AU", Name = "Australia", Order = 0 },
                        new { Id = 15, Code = "AW", Name = "Aruba", Order = 1 },
                        new { Id = 16, Code = "AX", Name = "Aland Islands", Order = 1 },
                        new { Id = 17, Code = "AZ", Name = "Azerbaijan", Order = 1 },
                        new { Id = 18, Code = "BA", Name = "Bosnia and Herzegovina", Order = 1 },
                        new { Id = 19, Code = "BB", Name = "Barbados", Order = 1 },
                        new { Id = 20, Code = "BD", Name = "Bangladesh", Order = 1 },
                        new { Id = 21, Code = "BE", Name = "Belgium", Order = 1 },
                        new { Id = 22, Code = "BF", Name = "Burkina Faso", Order = 1 },
                        new { Id = 23, Code = "BG", Name = "Bulgaria", Order = 1 },
                        new { Id = 24, Code = "BH", Name = "Bahrain", Order = 1 },
                        new { Id = 25, Code = "BI", Name = "Burundi", Order = 1 },
                        new { Id = 26, Code = "BJ", Name = "Benin", Order = 1 },
                        new { Id = 27, Code = "BM", Name = "Bermuda", Order = 1 },
                        new { Id = 28, Code = "BN", Name = "Brunei Darussalam", Order = 1 },
                        new { Id = 29, Code = "BO", Name = "Bolivia", Order = 1 },
                        new { Id = 30, Code = "BR", Name = "Brazil", Order = 1 },
                        new { Id = 31, Code = "BS", Name = "Bahamas", Order = 1 },
                        new { Id = 32, Code = "BT", Name = "Bhutan", Order = 1 },
                        new { Id = 33, Code = "BV", Name = "Bouvet Island", Order = 1 },
                        new { Id = 34, Code = "BW", Name = "Botswana", Order = 1 },
                        new { Id = 35, Code = "BY", Name = "Belarus", Order = 1 },
                        new { Id = 36, Code = "BZ", Name = "Belize", Order = 1 },
                        new { Id = 37, Code = "CA", Name = "Canada", Order = 1 },
                        new { Id = 38, Code = "CC", Name = "Cocos (Keeling) Islands", Order = 1 },
                        new { Id = 39, Code = "CD", Name = "Democratic Republic of the Congo", Order = 1 },
                        new { Id = 40, Code = "CF", Name = "Central African Republic", Order = 1 },
                        new { Id = 41, Code = "CG", Name = "Congo", Order = 1 },
                        new { Id = 42, Code = "CH", Name = "Switzerland", Order = 1 },
                        new { Id = 43, Code = "CI", Name = "Cote D'Ivoire(Ivory Coast)", Order = 1 },
                        new { Id = 44, Code = "CK", Name = "Cook Islands", Order = 1 },
                        new { Id = 45, Code = "CL", Name = "Chile", Order = 1 },
                        new { Id = 46, Code = "CM", Name = "Cameroon", Order = 1 },
                        new { Id = 47, Code = "CN", Name = "China", Order = 1 },
                        new { Id = 48, Code = "CO", Name = "Colombia", Order = 1 },
                        new { Id = 49, Code = "CR", Name = "Costa Rica", Order = 1 },
                        new { Id = 50, Code = "CS", Name = "Serbia and Montenegro", Order = 1 },
                        new { Id = 51, Code = "CU", Name = "Cuba", Order = 1 },
                        new { Id = 52, Code = "CV", Name = "Cape Verde", Order = 1 },
                        new { Id = 53, Code = "CX", Name = "Christmas Island", Order = 1 },
                        new { Id = 54, Code = "CY", Name = "Cyprus", Order = 1 },
                        new { Id = 55, Code = "CZ", Name = "Czech Republic", Order = 1 },
                        new { Id = 56, Code = "DE", Name = "Germany", Order = 1 },
                        new { Id = 57, Code = "DJ", Name = "Djibouti", Order = 1 },
                        new { Id = 58, Code = "DK", Name = "Denmark", Order = 1 },
                        new { Id = 59, Code = "DM", Name = "Dominica", Order = 1 },
                        new { Id = 60, Code = "DO", Name = "Dominican Republic", Order = 1 },
                        new { Id = 61, Code = "DZ", Name = "Algeria", Order = 1 },
                        new { Id = 62, Code = "EC", Name = "Ecuador", Order = 1 },
                        new { Id = 63, Code = "EE", Name = "Estonia", Order = 1 },
                        new { Id = 64, Code = "EG", Name = "Egypt", Order = 1 },
                        new { Id = 65, Code = "EH", Name = "Western Sahara", Order = 1 },
                        new { Id = 66, Code = "ER", Name = "Eritrea", Order = 1 },
                        new { Id = 67, Code = "ES", Name = "Spain", Order = 1 },
                        new { Id = 68, Code = "ET", Name = "Ethiopia", Order = 1 },
                        new { Id = 69, Code = "FI", Name = "Finland", Order = 1 },
                        new { Id = 70, Code = "FJ", Name = "Fiji", Order = 1 },
                        new { Id = 71, Code = "FK", Name = "Falkland Islands (Malvinas)", Order = 1 },
                        new { Id = 72, Code = "FM", Name = "Federated States of Micronesia", Order = 1 },
                        new { Id = 73, Code = "FO", Name = "Faroe Islands", Order = 1 },
                        new { Id = 74, Code = "FR", Name = "France", Order = 1 },
                        new { Id = 75, Code = "FX", Name = "France, Metropolitan", Order = 1 },
                        new { Id = 76, Code = "GA", Name = "Gabon", Order = 1 },
                        new { Id = 77, Code = "GB", Name = "Great Britain (UK)", Order = 1 },
                        new { Id = 78, Code = "GD", Name = "Grenada", Order = 1 },
                        new { Id = 79, Code = "GE", Name = "Georgia", Order = 1 },
                        new { Id = 80, Code = "GF", Name = "French Guiana", Order = 1 },
                        new { Id = 81, Code = "GH", Name = "Ghana", Order = 1 },
                        new { Id = 82, Code = "GI", Name = "Gibraltar", Order = 1 },
                        new { Id = 83, Code = "GL", Name = "Greenland", Order = 1 },
                        new { Id = 84, Code = "GM", Name = "Gambia", Order = 1 },
                        new { Id = 85, Code = "GN", Name = "Guinea", Order = 1 },
                        new { Id = 86, Code = "GP", Name = "Guadeloupe", Order = 1 },
                        new { Id = 87, Code = "GQ", Name = "Equatorial Guinea", Order = 1 },
                        new { Id = 88, Code = "GR", Name = "Greece", Order = 1 },
                        new { Id = 89, Code = "GS", Name = "S. Georgia and S. Sandwich Islands", Order = 1 },
                        new { Id = 90, Code = "GT", Name = "Guatemala", Order = 1 },
                        new { Id = 91, Code = "GU", Name = "Guam", Order = 1 },
                        new { Id = 92, Code = "GW", Name = "Guinea-Bissau", Order = 1 },
                        new { Id = 93, Code = "GY", Name = "Guyana", Order = 1 },
                        new { Id = 94, Code = "HK", Name = "Hong Kong", Order = 1 },
                        new { Id = 95, Code = "HM", Name = "Heard Island and McDonald Islands", Order = 1 },
                        new { Id = 96, Code = "HN", Name = "Honduras", Order = 1 },
                        new { Id = 97, Code = "HR", Name = "Croatia (Hrvatska)", Order = 1 },
                        new { Id = 98, Code = "HT", Name = "Haiti", Order = 1 },
                        new { Id = 99, Code = "HU", Name = "Hungary", Order = 1 },
                        new { Id = 100, Code = "ID", Name = "Indonesia", Order = 1 },
                        new { Id = 101, Code = "IE", Name = "Ireland", Order = 1 },
                        new { Id = 102, Code = "IL", Name = "Israel", Order = 1 },
                        new { Id = 103, Code = "IN", Name = "India", Order = 0 },
                        new { Id = 104, Code = "IO", Name = "British Indian Ocean Territory", Order = 1 },
                        new { Id = 105, Code = "IQ", Name = "Iraq", Order = 1 },
                        new { Id = 106, Code = "IR", Name = "Iran", Order = 1 },
                        new { Id = 107, Code = "IS", Name = "Iceland", Order = 1 },
                        new { Id = 108, Code = "IT", Name = "Italy", Order = 1 },
                        new { Id = 109, Code = "JM", Name = "Jamaica", Order = 1 },
                        new { Id = 110, Code = "JO", Name = "Jordan", Order = 1 },
                        new { Id = 111, Code = "JP", Name = "Japan", Order = 1 },
                        new { Id = 112, Code = "KE", Name = "Kenya", Order = 1 },
                        new { Id = 113, Code = "KG", Name = "Kyrgyzstan", Order = 1 },
                        new { Id = 114, Code = "KH", Name = "Cambodia", Order = 1 },
                        new { Id = 115, Code = "KI", Name = "Kiribati", Order = 1 },
                        new { Id = 116, Code = "KM", Name = "Comoros", Order = 1 },
                        new { Id = 117, Code = "KN", Name = "Saint Kitts and Nevis", Order = 1 },
                        new { Id = 118, Code = "KP", Name = "Korea (North)", Order = 1 },
                        new { Id = 119, Code = "KR", Name = "Korea (South)", Order = 1 },
                        new { Id = 120, Code = "KW", Name = "Kuwait", Order = 1 },
                        new { Id = 121, Code = "KY", Name = "Cayman Islands", Order = 1 },
                        new { Id = 122, Code = "KZ", Name = "Kazakhstan", Order = 1 },
                        new { Id = 123, Code = "LA", Name = "Laos", Order = 1 },
                        new { Id = 124, Code = "LB", Name = "Lebanon", Order = 1 },
                        new { Id = 125, Code = "LC", Name = "Saint Lucia", Order = 1 },
                        new { Id = 126, Code = "LI", Name = "Liechtenstein", Order = 1 },
                        new { Id = 127, Code = "LK", Name = "Sri Lanka", Order = 1 },
                        new { Id = 128, Code = "LR", Name = "Liberia", Order = 1 },
                        new { Id = 129, Code = "LS", Name = "Lesotho", Order = 1 },
                        new { Id = 130, Code = "LT", Name = "Lithuania", Order = 1 },
                        new { Id = 131, Code = "LU", Name = "Luxembourg", Order = 1 },
                        new { Id = 132, Code = "LV", Name = "Latvia", Order = 1 },
                        new { Id = 133, Code = "LY", Name = "Libya", Order = 1 },
                        new { Id = 134, Code = "MA", Name = "Morocco", Order = 1 },
                        new { Id = 135, Code = "MC", Name = "Monaco", Order = 1 },
                        new { Id = 136, Code = "MD", Name = "Moldova", Order = 1 },
                        new { Id = 137, Code = "MG", Name = "Madagascar", Order = 1 },
                        new { Id = 138, Code = "MH", Name = "Marshall Islands", Order = 1 },
                        new { Id = 139, Code = "MK", Name = "Macedonia", Order = 1 },
                        new { Id = 140, Code = "ML", Name = "Mali", Order = 1 },
                        new { Id = 141, Code = "MM", Name = "Myanmar", Order = 1 },
                        new { Id = 142, Code = "MN", Name = "Mongolia", Order = 1 },
                        new { Id = 143, Code = "MO", Name = "Macao", Order = 1 },
                        new { Id = 144, Code = "MP", Name = "Northern Mariana Islands", Order = 1 },
                        new { Id = 145, Code = "MQ", Name = "Martinique", Order = 1 },
                        new { Id = 146, Code = "MR", Name = "Mauritania", Order = 1 },
                        new { Id = 147, Code = "MS", Name = "Montserrat", Order = 1 },
                        new { Id = 148, Code = "MT", Name = "Malta", Order = 1 },
                        new { Id = 149, Code = "MU", Name = "Mauritius", Order = 1 },
                        new { Id = 150, Code = "MV", Name = "Maldives", Order = 1 },
                        new { Id = 151, Code = "MW", Name = "Malawi", Order = 1 },
                        new { Id = 152, Code = "MX", Name = "Mexico", Order = 1 },
                        new { Id = 153, Code = "MY", Name = "Malaysia", Order = 1 },
                        new { Id = 154, Code = "MZ", Name = "Mozambique", Order = 1 },
                        new { Id = 155, Code = "NA", Name = "Namibia", Order = 1 },
                        new { Id = 156, Code = "NC", Name = "New Caledonia", Order = 1 },
                        new { Id = 157, Code = "NE", Name = "Niger", Order = 1 },
                        new { Id = 158, Code = "NF", Name = "Norfolk Island", Order = 1 },
                        new { Id = 159, Code = "NG", Name = "Nigeria", Order = 1 },
                        new { Id = 160, Code = "NI", Name = "Nicaragua", Order = 1 },
                        new { Id = 161, Code = "NL", Name = "Netherlands", Order = 1 },
                        new { Id = 162, Code = "NO", Name = "Norway", Order = 1 },
                        new { Id = 163, Code = "NP", Name = "Nepal", Order = 1 },
                        new { Id = 164, Code = "NR", Name = "Nauru", Order = 1 },
                        new { Id = 165, Code = "NU", Name = "Niue", Order = 1 },
                        new { Id = 166, Code = "NZ", Name = "New Zealand", Order = 1 },
                        new { Id = 167, Code = "OM", Name = "Oman", Order = 1 },
                        new { Id = 168, Code = "PA", Name = "Panama", Order = 1 },
                        new { Id = 169, Code = "PE", Name = "Peru", Order = 1 },
                        new { Id = 170, Code = "PF", Name = "French Polynesia", Order = 1 },
                        new { Id = 171, Code = "PG", Name = "Papua New Guinea", Order = 1 },
                        new { Id = 172, Code = "PH", Name = "Philippines", Order = 1 },
                        new { Id = 173, Code = "PK", Name = "Pakistan", Order = 1 },
                        new { Id = 174, Code = "PL", Name = "Poland", Order = 1 },
                        new { Id = 175, Code = "PM", Name = "Saint Pierre and Miquelon", Order = 1 },
                        new { Id = 176, Code = "PN", Name = "Pitcairn", Order = 1 },
                        new { Id = 177, Code = "PR", Name = "Puerto Rico", Order = 1 },
                        new { Id = 178, Code = "PS", Name = "Palestinian Territory", Order = 1 },
                        new { Id = 179, Code = "PT", Name = "Portugal", Order = 1 },
                        new { Id = 180, Code = "PW", Name = "Palau", Order = 1 },
                        new { Id = 181, Code = "PY", Name = "Paraguay", Order = 1 },
                        new { Id = 182, Code = "QA", Name = "Qatar", Order = 1 },
                        new { Id = 183, Code = "RE", Name = "Reunion", Order = 1 },
                        new { Id = 184, Code = "RO", Name = "Romania", Order = 1 },
                        new { Id = 185, Code = "RU", Name = "Russian Federation", Order = 1 },
                        new { Id = 186, Code = "RW", Name = "Rwanda", Order = 1 },
                        new { Id = 187, Code = "SA", Name = "Saudi Arabia", Order = 1 },
                        new { Id = 188, Code = "SB", Name = "Solomon Islands", Order = 1 },
                        new { Id = 189, Code = "SC", Name = "Seychelles", Order = 1 },
                        new { Id = 190, Code = "SD", Name = "Sudan", Order = 1 },
                        new { Id = 191, Code = "SE", Name = "Sweden", Order = 1 },
                        new { Id = 192, Code = "SG", Name = "Singapore", Order = 1 },
                        new { Id = 193, Code = "SH", Name = "Saint Helena", Order = 1 },
                        new { Id = 194, Code = "SI", Name = "Slovenia", Order = 1 },
                        new { Id = 195, Code = "SJ", Name = "Svalbard and Jan Mayen", Order = 1 },
                        new { Id = 196, Code = "SK", Name = "Slovakia", Order = 1 },
                        new { Id = 197, Code = "SL", Name = "Sierra Leone", Order = 1 },
                        new { Id = 198, Code = "SM", Name = "San Marino", Order = 1 },
                        new { Id = 199, Code = "SN", Name = "Senegal", Order = 1 },
                        new { Id = 200, Code = "SO", Name = "Somalia", Order = 1 },
                        new { Id = 201, Code = "SR", Name = "Suriname", Order = 1 },
                        new { Id = 202, Code = "ST", Name = "Sao Tome and Principe", Order = 1 },
                        new { Id = 203, Code = "SU", Name = "USSR (former)", Order = 1 },
                        new { Id = 204, Code = "SV", Name = "El Salvador", Order = 1 },
                        new { Id = 205, Code = "SY", Name = "Syria", Order = 1 },
                        new { Id = 206, Code = "SZ", Name = "Swaziland", Order = 1 },
                        new { Id = 207, Code = "TC", Name = "Turks and Caicos Islands", Order = 1 },
                        new { Id = 208, Code = "TD", Name = "Chad", Order = 1 },
                        new { Id = 209, Code = "TF", Name = "French Southern Territories", Order = 1 },
                        new { Id = 210, Code = "TG", Name = "Togo", Order = 1 },
                        new { Id = 211, Code = "TH", Name = "Thailand", Order = 1 },
                        new { Id = 212, Code = "TJ", Name = "Tajikistan", Order = 1 },
                        new { Id = 213, Code = "TK", Name = "Tokelau", Order = 1 },
                        new { Id = 214, Code = "TL", Name = "Timor-Leste", Order = 1 },
                        new { Id = 215, Code = "TM", Name = "Turkmenistan", Order = 1 },
                        new { Id = 216, Code = "TN", Name = "Tunisia", Order = 1 },
                        new { Id = 217, Code = "TO", Name = "Tonga", Order = 1 },
                        new { Id = 218, Code = "TP", Name = "East Timor", Order = 1 },
                        new { Id = 219, Code = "TR", Name = "Turkey", Order = 1 },
                        new { Id = 220, Code = "TT", Name = "Trinidad and Tobago", Order = 1 },
                        new { Id = 221, Code = "TV", Name = "Tuvalu", Order = 1 },
                        new { Id = 222, Code = "TW", Name = "Taiwan", Order = 1 },
                        new { Id = 223, Code = "TZ", Name = "Tanzania", Order = 1 },
                        new { Id = 224, Code = "UA", Name = "Ukraine", Order = 1 },
                        new { Id = 225, Code = "UG", Name = "Uganda", Order = 1 },
                        new { Id = 226, Code = "UK", Name = "United Kingdom", Order = 0 },
                        new { Id = 227, Code = "UM", Name = "United States Minor Outlying Islands", Order = 1 },
                        new { Id = 228, Code = "US", Name = "United States", Order = 0 },
                        new { Id = 229, Code = "UY", Name = "Uruguay", Order = 1 },
                        new { Id = 230, Code = "UZ", Name = "Uzbekistan", Order = 1 },
                        new { Id = 231, Code = "VA", Name = "Vatican City State (Holy See)", Order = 1 },
                        new { Id = 232, Code = "VC", Name = "Saint Vincent and the Grenadines", Order = 1 },
                        new { Id = 233, Code = "VE", Name = "Venezuela", Order = 1 },
                        new { Id = 234, Code = "VG", Name = "Virgin Islands (British)", Order = 1 },
                        new { Id = 235, Code = "VI", Name = "Virgin Islands (U.S.)", Order = 1 },
                        new { Id = 236, Code = "VN", Name = "Viet Nam", Order = 1 },
                        new { Id = 237, Code = "VU", Name = "Vanuatu", Order = 1 },
                        new { Id = 238, Code = "WF", Name = "Wallis and Futuna", Order = 1 },
                        new { Id = 239, Code = "WS", Name = "Samoa", Order = 1 },
                        new { Id = 240, Code = "YE", Name = "Yemen", Order = 1 },
                        new { Id = 241, Code = "YT", Name = "Mayotte", Order = 1 },
                        new { Id = 242, Code = "YU", Name = "Yugoslavia (former)", Order = 1 },
                        new { Id = 243, Code = "ZA", Name = "South Africa", Order = 1 },
                        new { Id = 244, Code = "ZM", Name = "Zambia", Order = 1 },
                        new { Id = 245, Code = "ZR", Name = "Zaire (former)", Order = 1 },
                        new { Id = 246, Code = "ZW", Name = "Zimbabwe", Order = 1 },
                        new { Id = 251, Code = "CH", Name = "Switzerland", Order = 1 },
                        new { Id = 252, Code = "CH", Name = "Switzerland", Order = 1 },
                        new { Id = 267, Code = "NO", Name = "Norway", Order = 1 },
                        new { Id = 269, Code = "SP", Name = "Serbia", Order = 1 },
                        new { Id = 275, Code = "ZZ", Name = "Uknown", Order = 1 },
                        new { Id = 276, Code = "IM", Name = "Isle of Man", Order = 1 },
                        new { Id = 277, Code = "AP", Name = "Asia/Pacific Region", Order = 1 },
                        new { Id = 278, Code = "GE", Name = "Guernsey", Order = 1 },
                        new { Id = 279, Code = "AD", Name = "Andorra", Order = 1 }
                    );
                });

            modelBuilder.Entity("AutoPay.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(512);

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("CardType")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Ccv")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("City")
                        .HasMaxLength(256);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("CountryId")
                        .HasColumnName("FK_Countries")
                        .HasMaxLength(32);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnName("FK_AspNetUsers")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedOn")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("ExpiryMonth")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("ExpiryYear")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(512);

                    b.Property<string>("State")
                        .HasMaxLength(256);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("UpdatedOn");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AutoPay.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthCode")
                        .HasMaxLength(50);

                    b.Property<int>("BatchCustomerId")
                        .HasColumnName("FK_BatchCustomers");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsSuccess");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("BatchCustomerId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("AutoPay.Entities.PaymentError", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasMaxLength(512);

                    b.Property<int>("PaymentId")
                        .HasColumnName("FK_Payments");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.ToTable("PaymentErrors");
                });

            modelBuilder.Entity("AutoPay.Entities.RemoteDbConfig", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(40);

                    b.Property<string>("Database")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Server")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("UserId");

                    b.ToTable("RemoteDbConfigs");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AutoPay.Entities.BatchCustomer", b =>
                {
                    b.HasOne("AutoPay.Entities.Batch", "Batch")
                        .WithMany("Customers")
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutoPay.Entities.Payment", b =>
                {
                    b.HasOne("AutoPay.Entities.BatchCustomer")
                        .WithMany("Payments")
                        .HasForeignKey("BatchCustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutoPay.Entities.PaymentError", b =>
                {
                    b.HasOne("AutoPay.Entities.Payment")
                        .WithMany("Errors")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
