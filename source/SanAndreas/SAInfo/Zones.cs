﻿// LogiFrame rendering library.
// Copyright (C) 2014 Tim Potze
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>. 

using System;
using System.Linq;

namespace SanAndreas.SAInfo
{
    public static class Zones
    {
        #region Data

        private static readonly Zone[] SanAndreasZones =
        {
            new Zone("The Big Ear", new[] {-410.00, 1403.30, -3.00, -137.90, 1681.20, 200.00}),
            new Zone("Aldea Malvada", new[] {-1372.10, 2498.50, 0.00, -1277.50, 2615.30, 200.00}),
            new Zone("Angel Pine", new[] {-2324.90, -2584.20, -6.10, -1964.20, -2212.10, 200.00}),
            new Zone("Arco del Oeste", new[] {-901.10, 2221.80, 0.00, -592.00, 2571.90, 200.00}),
            new Zone("Avispa Country Club", new[] {-2646.40, -355.40, 0.00, -2270.00, -222.50, 200.00}),
            new Zone("Avispa Country Club", new[] {-2831.80, -430.20, -6.10, -2646.40, -222.50, 200.00}),
            new Zone("Avispa Country Club", new[] {-2361.50, -417.10, 0.00, -2270.00, -355.40, 200.00}),
            new Zone("Avispa Country Club", new[] {-2667.80, -302.10, -28.80, -2646.40, -262.30, 71.10}),
            new Zone("Avispa Country Club", new[] {-2470.00, -355.40, 0.00, -2270.00, -318.40, 46.10}),
            new Zone("Avispa Country Club", new[] {-2550.00, -355.40, 0.00, -2470.00, -318.40, 39.70}),
            new Zone("Back o Beyond", new[] {-1166.90, -2641.10, 0.00, -321.70, -1856.00, 200.00}),
            new Zone("Battery Point", new[] {-2741.00, 1268.40, -4.50, -2533.00, 1490.40, 200.00}),
            new Zone("Bayside", new[] {-2741.00, 2175.10, 0.00, -2353.10, 2722.70, 200.00}),
            new Zone("Bayside Marina", new[] {-2353.10, 2275.70, 0.00, -2153.10, 2475.70, 200.00}),
            new Zone("Beacon Hill", new[] {-399.60, -1075.50, -1.40, -319.00, -977.50, 198.50}),
            new Zone("Blackfield", new[] {964.30, 1203.20, -89.00, 1197.30, 1403.20, 110.90}),
            new Zone("Blackfield", new[] {964.30, 1403.20, -89.00, 1197.30, 1726.20, 110.90}),
            new Zone("Blackfield Chapel", new[] {1375.60, 596.30, -89.00, 1558.00, 823.20, 110.90}),
            new Zone("Blackfield Chapel", new[] {1325.60, 596.30, -89.00, 1375.60, 795.00, 110.90}),
            new Zone("Blackfield Intersection", new[] {1197.30, 1044.60, -89.00, 1277.00, 1163.30, 110.90}),
            new Zone("Blackfield Intersection", new[] {1166.50, 795.00, -89.00, 1375.60, 1044.60, 110.90}),
            new Zone("Blackfield Intersection", new[] {1277.00, 1044.60, -89.00, 1315.30, 1087.60, 110.90}),
            new Zone("Blackfield Intersection", new[] {1375.60, 823.20, -89.00, 1457.30, 919.40, 110.90}),
            new Zone("Blueberry", new[] {104.50, -220.10, 2.30, 349.60, 152.20, 200.00}),
            new Zone("Blueberry", new[] {19.60, -404.10, 3.80, 349.60, -220.10, 200.00}),
            new Zone("Blueberry Acres", new[] {-319.60, -220.10, 0.00, 104.50, 293.30, 200.00}),
            new Zone("Caligula's Palace", new[] {2087.30, 1543.20, -89.00, 2437.30, 1703.20, 110.90}),
            new Zone("Caligula's Palace", new[] {2137.40, 1703.20, -89.00, 2437.30, 1783.20, 110.90}),
            new Zone("Calton Heights", new[] {-2274.10, 744.10, -6.10, -1982.30, 1358.90, 200.00}),
            new Zone("Chinatown", new[] {-2274.10, 578.30, -7.60, -2078.60, 744.10, 200.00}),
            new Zone("City Hall", new[] {-2867.80, 277.40, -9.10, -2593.40, 458.40, 200.00}),
            new Zone("Come-A-Lot", new[] {2087.30, 943.20, -89.00, 2623.10, 1203.20, 110.90}),
            new Zone("Commerce", new[] {1323.90, -1842.20, -89.00, 1701.90, -1722.20, 110.90}),
            new Zone("Commerce", new[] {1323.90, -1722.20, -89.00, 1440.90, -1577.50, 110.90}),
            new Zone("Commerce", new[] {1370.80, -1577.50, -89.00, 1463.90, -1384.90, 110.90}),
            new Zone("Commerce", new[] {1463.90, -1577.50, -89.00, 1667.90, -1430.80, 110.90}),
            new Zone("Commerce", new[] {1583.50, -1722.20, -89.00, 1758.90, -1577.50, 110.90}),
            new Zone("Commerce", new[] {1667.90, -1577.50, -89.00, 1812.60, -1430.80, 110.90}),
            new Zone("Conference Center", new[] {1046.10, -1804.20, -89.00, 1323.90, -1722.20, 110.90}),
            new Zone("Conference Center", new[] {1073.20, -1842.20, -89.00, 1323.90, -1804.20, 110.90}),
            new Zone("Cranberry Station", new[] {-2007.80, 56.30, 0.00, -1922.00, 224.70, 100.00}),
            new Zone("Creek", new[] {2749.90, 1937.20, -89.00, 2921.60, 2669.70, 110.90}),
            new Zone("Dillimore", new[] {580.70, -674.80, -9.50, 861.00, -404.70, 200.00}),
            new Zone("Doherty", new[] {-2270.00, -324.10, -0.00, -1794.90, -222.50, 200.00}),
            new Zone("Doherty", new[] {-2173.00, -222.50, -0.00, -1794.90, 265.20, 200.00}),
            new Zone("Downtown", new[] {-1982.30, 744.10, -6.10, -1871.70, 1274.20, 200.00}),
            new Zone("Downtown", new[] {-1871.70, 1176.40, -4.50, -1620.30, 1274.20, 200.00}),
            new Zone("Downtown", new[] {-1700.00, 744.20, -6.10, -1580.00, 1176.50, 200.00}),
            new Zone("Downtown", new[] {-1580.00, 744.20, -6.10, -1499.80, 1025.90, 200.00}),
            new Zone("Downtown", new[] {-2078.60, 578.30, -7.60, -1499.80, 744.20, 200.00}),
            new Zone("Downtown", new[] {-1993.20, 265.20, -9.10, -1794.90, 578.30, 200.00}),
            new Zone("Downtown Los Santos", new[] {1463.90, -1430.80, -89.00, 1724.70, -1290.80, 110.90}),
            new Zone("Downtown Los Santos", new[] {1724.70, -1430.80, -89.00, 1812.60, -1250.90, 110.90}),
            new Zone("Downtown Los Santos", new[] {1463.90, -1290.80, -89.00, 1724.70, -1150.80, 110.90}),
            new Zone("Downtown Los Santos", new[] {1370.80, -1384.90, -89.00, 1463.90, -1170.80, 110.90}),
            new Zone("Downtown Los Santos", new[] {1724.70, -1250.90, -89.00, 1812.60, -1150.80, 110.90}),
            new Zone("Downtown Los Santos", new[] {1370.80, -1170.80, -89.00, 1463.90, -1130.80, 110.90}),
            new Zone("Downtown Los Santos", new[] {1378.30, -1130.80, -89.00, 1463.90, -1026.30, 110.90}),
            new Zone("Downtown Los Santos", new[] {1391.00, -1026.30, -89.00, 1463.90, -926.90, 110.90}),
            new Zone("Downtown Los Santos", new[] {1507.50, -1385.20, 110.90, 1582.50, -1325.30, 335.90}),
            new Zone("East Beach", new[] {2632.80, -1852.80, -89.00, 2959.30, -1668.10, 110.90}),
            new Zone("East Beach", new[] {2632.80, -1668.10, -89.00, 2747.70, -1393.40, 110.90}),
            new Zone("East Beach", new[] {2747.70, -1668.10, -89.00, 2959.30, -1498.60, 110.90}),
            new Zone("East Beach", new[] {2747.70, -1498.60, -89.00, 2959.30, -1120.00, 110.90}),
            new Zone("East Los Santos", new[] {2421.00, -1628.50, -89.00, 2632.80, -1454.30, 110.90}),
            new Zone("East Los Santos", new[] {2222.50, -1628.50, -89.00, 2421.00, -1494.00, 110.90}),
            new Zone("East Los Santos", new[] {2266.20, -1494.00, -89.00, 2381.60, -1372.00, 110.90}),
            new Zone("East Los Santos", new[] {2381.60, -1494.00, -89.00, 2421.00, -1454.30, 110.90}),
            new Zone("East Los Santos", new[] {2281.40, -1372.00, -89.00, 2381.60, -1135.00, 110.90}),
            new Zone("East Los Santos", new[] {2381.60, -1454.30, -89.00, 2462.10, -1135.00, 110.90}),
            new Zone("East Los Santos", new[] {2462.10, -1454.30, -89.00, 2581.70, -1135.00, 110.90}),
            new Zone("Easter Basin", new[] {-1794.90, 249.90, -9.10, -1242.90, 578.30, 200.00}),
            new Zone("Easter Basin", new[] {-1794.90, -50.00, -0.00, -1499.80, 249.90, 200.00}),
            new Zone("Easter Bay Airport", new[] {-1499.80, -50.00, -0.00, -1242.90, 249.90, 200.00}),
            new Zone("Easter Bay Airport", new[] {-1794.90, -730.10, -3.00, -1213.90, -50.00, 200.00}),
            new Zone("Easter Bay Airport", new[] {-1213.90, -730.10, 0.00, -1132.80, -50.00, 200.00}),
            new Zone("Easter Bay Airport", new[] {-1242.90, -50.00, 0.00, -1213.90, 578.30, 200.00}),
            new Zone("Easter Bay Airport", new[] {-1213.90, -50.00, -4.50, -947.90, 578.30, 200.00}),
            new Zone("Easter Bay Airport", new[] {-1315.40, -405.30, 15.40, -1264.40, -209.50, 25.40}),
            new Zone("Easter Bay Airport", new[] {-1354.30, -287.30, 15.40, -1315.40, -209.50, 25.40}),
            new Zone("Easter Bay Airport", new[] {-1490.30, -209.50, 15.40, -1264.40, -148.30, 25.40}),
            new Zone("Easter Bay Chemicals", new[] {-1132.80, -768.00, 0.00, -956.40, -578.10, 200.00}),
            new Zone("Easter Bay Chemicals", new[] {-1132.80, -787.30, 0.00, -956.40, -768.00, 200.00}),
            new Zone("El Castillo del Diablo", new[] {-464.50, 2217.60, 0.00, -208.50, 2580.30, 200.00}),
            new Zone("El Castillo del Diablo", new[] {-208.50, 2123.00, -7.60, 114.00, 2337.10, 200.00}),
            new Zone("El Castillo del Diablo", new[] {-208.50, 2337.10, 0.00, 8.40, 2487.10, 200.00}),
            new Zone("El Corona", new[] {1812.60, -2179.20, -89.00, 1970.60, -1852.80, 110.90}),
            new Zone("El Corona", new[] {1692.60, -2179.20, -89.00, 1812.60, -1842.20, 110.90}),
            new Zone("El Quebrados", new[] {-1645.20, 2498.50, 0.00, -1372.10, 2777.80, 200.00}),
            new Zone("Esplanade East", new[] {-1620.30, 1176.50, -4.50, -1580.00, 1274.20, 200.00}),
            new Zone("Esplanade East", new[] {-1580.00, 1025.90, -6.10, -1499.80, 1274.20, 200.00}),
            new Zone("Esplanade East", new[] {-1499.80, 578.30, -79.60, -1339.80, 1274.20, 20.30}),
            new Zone("Esplanade North", new[] {-2533.00, 1358.90, -4.50, -1996.60, 1501.20, 200.00}),
            new Zone("Esplanade North", new[] {-1996.60, 1358.90, -4.50, -1524.20, 1592.50, 200.00}),
            new Zone("Esplanade North", new[] {-1982.30, 1274.20, -4.50, -1524.20, 1358.90, 200.00}),
            new Zone("Fallen Tree", new[] {-792.20, -698.50, -5.30, -452.40, -380.00, 200.00}),
            new Zone("Fallow Bridge", new[] {434.30, 366.50, 0.00, 603.00, 555.60, 200.00}),
            new Zone("Fern Ridge", new[] {508.10, -139.20, 0.00, 1306.60, 119.50, 200.00}),
            new Zone("Financial", new[] {-1871.70, 744.10, -6.10, -1701.30, 1176.40, 300.00}),
            new Zone("Fisher's Lagoon", new[] {1916.90, -233.30, -100.00, 2131.70, 13.80, 200.00}),
            new Zone("Flint Intersection", new[] {-187.70, -1596.70, -89.00, 17.00, -1276.60, 110.90}),
            new Zone("Flint Range", new[] {-594.10, -1648.50, 0.00, -187.70, -1276.60, 200.00}),
            new Zone("Fort Carson", new[] {-376.20, 826.30, -3.00, 123.70, 1220.40, 200.00}),
            new Zone("Foster Valley", new[] {-2270.00, -430.20, -0.00, -2178.60, -324.10, 200.00}),
            new Zone("Foster Valley", new[] {-2178.60, -599.80, -0.00, -1794.90, -324.10, 200.00}),
            new Zone("Foster Valley", new[] {-2178.60, -1115.50, 0.00, -1794.90, -599.80, 200.00}),
            new Zone("Foster Valley", new[] {-2178.60, -1250.90, 0.00, -1794.90, -1115.50, 200.00}),
            new Zone("Frederick Bridge", new[] {2759.20, 296.50, 0.00, 2774.20, 594.70, 200.00}),
            new Zone("Gant Bridge", new[] {-2741.40, 1659.60, -6.10, -2616.40, 2175.10, 200.00}),
            new Zone("Gant Bridge", new[] {-2741.00, 1490.40, -6.10, -2616.40, 1659.60, 200.00}),
            new Zone("Ganton", new[] {2222.50, -1852.80, -89.00, 2632.80, -1722.30, 110.90}),
            new Zone("Ganton", new[] {2222.50, -1722.30, -89.00, 2632.80, -1628.50, 110.90}),
            new Zone("Garcia", new[] {-2411.20, -222.50, -0.00, -2173.00, 265.20, 200.00}),
            new Zone("Garcia", new[] {-2395.10, -222.50, -5.30, -2354.00, -204.70, 200.00}),
            new Zone("Garver Bridge", new[] {-1339.80, 828.10, -89.00, -1213.90, 1057.00, 110.90}),
            new Zone("Garver Bridge", new[] {-1213.90, 950.00, -89.00, -1087.90, 1178.90, 110.90}),
            new Zone("Garver Bridge", new[] {-1499.80, 696.40, -179.60, -1339.80, 925.30, 20.30}),
            new Zone("Glen Park", new[] {1812.60, -1449.60, -89.00, 1996.90, -1350.70, 110.90}),
            new Zone("Glen Park", new[] {1812.60, -1100.80, -89.00, 1994.30, -973.30, 110.90}),
            new Zone("Glen Park", new[] {1812.60, -1350.70, -89.00, 2056.80, -1100.80, 110.90}),
            new Zone("Green Palms", new[] {176.50, 1305.40, -3.00, 338.60, 1520.70, 200.00}),
            new Zone("Greenglass College", new[] {964.30, 1044.60, -89.00, 1197.30, 1203.20, 110.90}),
            new Zone("Greenglass College", new[] {964.30, 930.80, -89.00, 1166.50, 1044.60, 110.90}),
            new Zone("Hampton Barns", new[] {603.00, 264.30, 0.00, 761.90, 366.50, 200.00}),
            new Zone("Hankypanky Point", new[] {2576.90, 62.10, 0.00, 2759.20, 385.50, 200.00}),
            new Zone("Harry Gold Parkway", new[] {1777.30, 863.20, -89.00, 1817.30, 2342.80, 110.90}),
            new Zone("Hashbury", new[] {-2593.40, -222.50, -0.00, -2411.20, 54.70, 200.00}),
            new Zone("Hilltop Farm", new[] {967.30, -450.30, -3.00, 1176.70, -217.90, 200.00}),
            new Zone("Hunter Quarry", new[] {337.20, 710.80, -115.20, 860.50, 1031.70, 203.70}),
            new Zone("Idlewood", new[] {1812.60, -1852.80, -89.00, 1971.60, -1742.30, 110.90}),
            new Zone("Idlewood", new[] {1812.60, -1742.30, -89.00, 1951.60, -1602.30, 110.90}),
            new Zone("Idlewood", new[] {1951.60, -1742.30, -89.00, 2124.60, -1602.30, 110.90}),
            new Zone("Idlewood", new[] {1812.60, -1602.30, -89.00, 2124.60, -1449.60, 110.90}),
            new Zone("Idlewood", new[] {2124.60, -1742.30, -89.00, 2222.50, -1494.00, 110.90}),
            new Zone("Idlewood", new[] {1971.60, -1852.80, -89.00, 2222.50, -1742.30, 110.90}),
            new Zone("Jefferson", new[] {1996.90, -1449.60, -89.00, 2056.80, -1350.70, 110.90}),
            new Zone("Jefferson", new[] {2124.60, -1494.00, -89.00, 2266.20, -1449.60, 110.90}),
            new Zone("Jefferson", new[] {2056.80, -1372.00, -89.00, 2281.40, -1210.70, 110.90}),
            new Zone("Jefferson", new[] {2056.80, -1210.70, -89.00, 2185.30, -1126.30, 110.90}),
            new Zone("Jefferson", new[] {2185.30, -1210.70, -89.00, 2281.40, -1154.50, 110.90}),
            new Zone("Jefferson", new[] {2056.80, -1449.60, -89.00, 2266.20, -1372.00, 110.90}),
            new Zone("Julius Thruway East", new[] {2623.10, 943.20, -89.00, 2749.90, 1055.90, 110.90}),
            new Zone("Julius Thruway East", new[] {2685.10, 1055.90, -89.00, 2749.90, 2626.50, 110.90}),
            new Zone("Julius Thruway East", new[] {2536.40, 2442.50, -89.00, 2685.10, 2542.50, 110.90}),
            new Zone("Julius Thruway East", new[] {2625.10, 2202.70, -89.00, 2685.10, 2442.50, 110.90}),
            new Zone("Julius Thruway North", new[] {2498.20, 2542.50, -89.00, 2685.10, 2626.50, 110.90}),
            new Zone("Julius Thruway North", new[] {2237.40, 2542.50, -89.00, 2498.20, 2663.10, 110.90}),
            new Zone("Julius Thruway North", new[] {2121.40, 2508.20, -89.00, 2237.40, 2663.10, 110.90}),
            new Zone("Julius Thruway North", new[] {1938.80, 2508.20, -89.00, 2121.40, 2624.20, 110.90}),
            new Zone("Julius Thruway North", new[] {1534.50, 2433.20, -89.00, 1848.40, 2583.20, 110.90}),
            new Zone("Julius Thruway North", new[] {1848.40, 2478.40, -89.00, 1938.80, 2553.40, 110.90}),
            new Zone("Julius Thruway North", new[] {1704.50, 2342.80, -89.00, 1848.40, 2433.20, 110.90}),
            new Zone("Julius Thruway North", new[] {1377.30, 2433.20, -89.00, 1534.50, 2507.20, 110.90}),
            new Zone("Julius Thruway South", new[] {1457.30, 823.20, -89.00, 2377.30, 863.20, 110.90}),
            new Zone("Julius Thruway South", new[] {2377.30, 788.80, -89.00, 2537.30, 897.90, 110.90}),
            new Zone("Julius Thruway West", new[] {1197.30, 1163.30, -89.00, 1236.60, 2243.20, 110.90}),
            new Zone("Julius Thruway West", new[] {1236.60, 2142.80, -89.00, 1297.40, 2243.20, 110.90}),
            new Zone("Juniper Hill", new[] {-2533.00, 578.30, -7.60, -2274.10, 968.30, 200.00}),
            new Zone("Juniper Hollow", new[] {-2533.00, 968.30, -6.10, -2274.10, 1358.90, 200.00}),
            new Zone("K.A.C.C. Military Fuels", new[] {2498.20, 2626.50, -89.00, 2749.90, 2861.50, 110.90}),
            new Zone("Kincaid Bridge", new[] {-1339.80, 599.20, -89.00, -1213.90, 828.10, 110.90}),
            new Zone("Kincaid Bridge", new[] {-1213.90, 721.10, -89.00, -1087.90, 950.00, 110.90}),
            new Zone("Kincaid Bridge", new[] {-1087.90, 855.30, -89.00, -961.90, 986.20, 110.90}),
            new Zone("King's", new[] {-2329.30, 458.40, -7.60, -1993.20, 578.30, 200.00}),
            new Zone("King's", new[] {-2411.20, 265.20, -9.10, -1993.20, 373.50, 200.00}),
            new Zone("King's", new[] {-2253.50, 373.50, -9.10, -1993.20, 458.40, 200.00}),
            new Zone("LVA Freight Depot", new[] {1457.30, 863.20, -89.00, 1777.40, 1143.20, 110.90}),
            new Zone("LVA Freight Depot", new[] {1375.60, 919.40, -89.00, 1457.30, 1203.20, 110.90}),
            new Zone("LVA Freight Depot", new[] {1277.00, 1087.60, -89.00, 1375.60, 1203.20, 110.90}),
            new Zone("LVA Freight Depot", new[] {1315.30, 1044.60, -89.00, 1375.60, 1087.60, 110.90}),
            new Zone("LVA Freight Depot", new[] {1236.60, 1163.40, -89.00, 1277.00, 1203.20, 110.90}),
            new Zone("Las Barrancas", new[] {-926.10, 1398.70, -3.00, -719.20, 1634.60, 200.00}),
            new Zone("Las Brujas", new[] {-365.10, 2123.00, -3.00, -208.50, 2217.60, 200.00}),
            new Zone("Las Colinas", new[] {1994.30, -1100.80, -89.00, 2056.80, -920.80, 110.90}),
            new Zone("Las Colinas", new[] {2056.80, -1126.30, -89.00, 2126.80, -920.80, 110.90}),
            new Zone("Las Colinas", new[] {2185.30, -1154.50, -89.00, 2281.40, -934.40, 110.90}),
            new Zone("Las Colinas", new[] {2126.80, -1126.30, -89.00, 2185.30, -934.40, 110.90}),
            new Zone("Las Colinas", new[] {2747.70, -1120.00, -89.00, 2959.30, -945.00, 110.90}),
            new Zone("Las Colinas", new[] {2632.70, -1135.00, -89.00, 2747.70, -945.00, 110.90}),
            new Zone("Las Colinas", new[] {2281.40, -1135.00, -89.00, 2632.70, -945.00, 110.90}),
            new Zone("Las Payasadas", new[] {-354.30, 2580.30, 2.00, -133.60, 2816.80, 200.00}),
            new Zone("Las Venturas Airport", new[] {1236.60, 1203.20, -89.00, 1457.30, 1883.10, 110.90}),
            new Zone("Las Venturas Airport", new[] {1457.30, 1203.20, -89.00, 1777.30, 1883.10, 110.90}),
            new Zone("Las Venturas Airport", new[] {1457.30, 1143.20, -89.00, 1777.40, 1203.20, 110.90}),
            new Zone("Las Venturas Airport", new[] {1515.80, 1586.40, -12.50, 1729.90, 1714.50, 87.50}),
            new Zone("Last Dime Motel", new[] {1823.00, 596.30, -89.00, 1997.20, 823.20, 110.90}),
            new Zone("Leafy Hollow", new[] {-1166.90, -1856.00, 0.00, -815.60, -1602.00, 200.00}),
            new Zone("Liberty City", new[] {-1000.00, 400.00, 1300.00, -700.00, 600.00, 1400.00}),
            new Zone("Lil' Probe Inn", new[] {-90.20, 1286.80, -3.00, 153.80, 1554.10, 200.00}),
            new Zone("Linden Side", new[] {2749.90, 943.20, -89.00, 2923.30, 1198.90, 110.90}),
            new Zone("Linden Station", new[] {2749.90, 1198.90, -89.00, 2923.30, 1548.90, 110.90}),
            new Zone("Linden Station", new[] {2811.20, 1229.50, -39.50, 2861.20, 1407.50, 60.40}),
            new Zone("Little Mexico", new[] {1701.90, -1842.20, -89.00, 1812.60, -1722.20, 110.90}),
            new Zone("Little Mexico", new[] {1758.90, -1722.20, -89.00, 1812.60, -1577.50, 110.90}),
            new Zone("Los Flores", new[] {2581.70, -1454.30, -89.00, 2632.80, -1393.40, 110.90}),
            new Zone("Los Flores", new[] {2581.70, -1393.40, -89.00, 2747.70, -1135.00, 110.90}),
            new Zone("Los Santos International", new[] {1249.60, -2394.30, -89.00, 1852.00, -2179.20, 110.90}),
            new Zone("Los Santos International", new[] {1852.00, -2394.30, -89.00, 2089.00, -2179.20, 110.90}),
            new Zone("Los Santos International", new[] {1382.70, -2730.80, -89.00, 2201.80, -2394.30, 110.90}),
            new Zone("Los Santos International", new[] {1974.60, -2394.30, -39.00, 2089.00, -2256.50, 60.90}),
            new Zone("Los Santos International", new[] {1400.90, -2669.20, -39.00, 2189.80, -2597.20, 60.90}),
            new Zone("Los Santos International", new[] {2051.60, -2597.20, -39.00, 2152.40, -2394.30, 60.90}),
            new Zone("Marina", new[] {647.70, -1804.20, -89.00, 851.40, -1577.50, 110.90}),
            new Zone("Marina", new[] {647.70, -1577.50, -89.00, 807.90, -1416.20, 110.90}),
            new Zone("Marina", new[] {807.90, -1577.50, -89.00, 926.90, -1416.20, 110.90}),
            new Zone("Market", new[] {787.40, -1416.20, -89.00, 1072.60, -1310.20, 110.90}),
            new Zone("Market", new[] {952.60, -1310.20, -89.00, 1072.60, -1130.80, 110.90}),
            new Zone("Market", new[] {1072.60, -1416.20, -89.00, 1370.80, -1130.80, 110.90}),
            new Zone("Market", new[] {926.90, -1577.50, -89.00, 1370.80, -1416.20, 110.90}),
            new Zone("Market Station", new[] {787.40, -1410.90, -34.10, 866.00, -1310.20, 65.80}),
            new Zone("Martin Bridge", new[] {-222.10, 293.30, 0.00, -122.10, 476.40, 200.00}),
            new Zone("Missionary Hill", new[] {-2994.40, -811.20, 0.00, -2178.60, -430.20, 200.00}),
            new Zone("Montgomery", new[] {1119.50, 119.50, -3.00, 1451.40, 493.30, 200.00}),
            new Zone("Montgomery", new[] {1451.40, 347.40, -6.10, 1582.40, 420.80, 200.00}),
            new Zone("Montgomery Intersection", new[] {1546.60, 208.10, 0.00, 1745.80, 347.40, 200.00}),
            new Zone("Montgomery Intersection", new[] {1582.40, 347.40, 0.00, 1664.60, 401.70, 200.00}),
            new Zone("Mulholland", new[] {1414.00, -768.00, -89.00, 1667.60, -452.40, 110.90}),
            new Zone("Mulholland", new[] {1281.10, -452.40, -89.00, 1641.10, -290.90, 110.90}),
            new Zone("Mulholland", new[] {1269.10, -768.00, -89.00, 1414.00, -452.40, 110.90}),
            new Zone("Mulholland", new[] {1357.00, -926.90, -89.00, 1463.90, -768.00, 110.90}),
            new Zone("Mulholland", new[] {1318.10, -910.10, -89.00, 1357.00, -768.00, 110.90}),
            new Zone("Mulholland", new[] {1169.10, -910.10, -89.00, 1318.10, -768.00, 110.90}),
            new Zone("Mulholland", new[] {768.60, -954.60, -89.00, 952.60, -860.60, 110.90}),
            new Zone("Mulholland", new[] {687.80, -860.60, -89.00, 911.80, -768.00, 110.90}),
            new Zone("Mulholland", new[] {737.50, -768.00, -89.00, 1142.20, -674.80, 110.90}),
            new Zone("Mulholland", new[] {1096.40, -910.10, -89.00, 1169.10, -768.00, 110.90}),
            new Zone("Mulholland", new[] {952.60, -937.10, -89.00, 1096.40, -860.60, 110.90}),
            new Zone("Mulholland", new[] {911.80, -860.60, -89.00, 1096.40, -768.00, 110.90}),
            new Zone("Mulholland", new[] {861.00, -674.80, -89.00, 1156.50, -600.80, 110.90}),
            new Zone("Mulholland Intersection", new[] {1463.90, -1150.80, -89.00, 1812.60, -768.00, 110.90}),
            new Zone("North Rock", new[] {2285.30, -768.00, 0.00, 2770.50, -269.70, 200.00}),
            new Zone("Ocean Docks", new[] {2373.70, -2697.00, -89.00, 2809.20, -2330.40, 110.90}),
            new Zone("Ocean Docks", new[] {2201.80, -2418.30, -89.00, 2324.00, -2095.00, 110.90}),
            new Zone("Ocean Docks", new[] {2324.00, -2302.30, -89.00, 2703.50, -2145.10, 110.90}),
            new Zone("Ocean Docks", new[] {2089.00, -2394.30, -89.00, 2201.80, -2235.80, 110.90}),
            new Zone("Ocean Docks", new[] {2201.80, -2730.80, -89.00, 2324.00, -2418.30, 110.90}),
            new Zone("Ocean Docks", new[] {2703.50, -2302.30, -89.00, 2959.30, -2126.90, 110.90}),
            new Zone("Ocean Docks", new[] {2324.00, -2145.10, -89.00, 2703.50, -2059.20, 110.90}),
            new Zone("Ocean Flats", new[] {-2994.40, 277.40, -9.10, -2867.80, 458.40, 200.00}),
            new Zone("Ocean Flats", new[] {-2994.40, -222.50, -0.00, -2593.40, 277.40, 200.00}),
            new Zone("Ocean Flats", new[] {-2994.40, -430.20, -0.00, -2831.80, -222.50, 200.00}),
            new Zone("Octane Springs", new[] {338.60, 1228.50, 0.00, 664.30, 1655.00, 200.00}),
            new Zone("Old Venturas Strip", new[] {2162.30, 2012.10, -89.00, 2685.10, 2202.70, 110.90}),
            new Zone("Palisades", new[] {-2994.40, 458.40, -6.10, -2741.00, 1339.60, 200.00}),
            new Zone("Palomino Creek", new[] {2160.20, -149.00, 0.00, 2576.90, 228.30, 200.00}),
            new Zone("Paradiso", new[] {-2741.00, 793.40, -6.10, -2533.00, 1268.40, 200.00}),
            new Zone("Pershing Square", new[] {1440.90, -1722.20, -89.00, 1583.50, -1577.50, 110.90}),
            new Zone("Pilgrim", new[] {2437.30, 1383.20, -89.00, 2624.40, 1783.20, 110.90}),
            new Zone("Pilgrim", new[] {2624.40, 1383.20, -89.00, 2685.10, 1783.20, 110.90}),
            new Zone("Pilson Intersection", new[] {1098.30, 2243.20, -89.00, 1377.30, 2507.20, 110.90}),
            new Zone("Pirates in Men's Pants", new[] {1817.30, 1469.20, -89.00, 2027.40, 1703.20, 110.90}),
            new Zone("Playa del Seville", new[] {2703.50, -2126.90, -89.00, 2959.30, -1852.80, 110.90}),
            new Zone("Prickle Pine", new[] {1534.50, 2583.20, -89.00, 1848.40, 2863.20, 110.90}),
            new Zone("Prickle Pine", new[] {1117.40, 2507.20, -89.00, 1534.50, 2723.20, 110.90}),
            new Zone("Prickle Pine", new[] {1848.40, 2553.40, -89.00, 1938.80, 2863.20, 110.90}),
            new Zone("Prickle Pine", new[] {1938.80, 2624.20, -89.00, 2121.40, 2861.50, 110.90}),
            new Zone("Queens", new[] {-2533.00, 458.40, 0.00, -2329.30, 578.30, 200.00}),
            new Zone("Queens", new[] {-2593.40, 54.70, 0.00, -2411.20, 458.40, 200.00}),
            new Zone("Queens", new[] {-2411.20, 373.50, 0.00, -2253.50, 458.40, 200.00}),
            new Zone("Randolph Industrial Estate", new[] {1558.00, 596.30, -89.00, 1823.00, 823.20, 110.90}),
            new Zone("Redsands East", new[] {1817.30, 2011.80, -89.00, 2106.70, 2202.70, 110.90}),
            new Zone("Redsands East", new[] {1817.30, 2202.70, -89.00, 2011.90, 2342.80, 110.90}),
            new Zone("Redsands East", new[] {1848.40, 2342.80, -89.00, 2011.90, 2478.40, 110.90}),
            new Zone("Redsands West", new[] {1236.60, 1883.10, -89.00, 1777.30, 2142.80, 110.90}),
            new Zone("Redsands West", new[] {1297.40, 2142.80, -89.00, 1777.30, 2243.20, 110.90}),
            new Zone("Redsands West", new[] {1377.30, 2243.20, -89.00, 1704.50, 2433.20, 110.90}),
            new Zone("Redsands West", new[] {1704.50, 2243.20, -89.00, 1777.30, 2342.80, 110.90}),
            new Zone("Regular Tom", new[] {-405.70, 1712.80, -3.00, -276.70, 1892.70, 200.00}),
            new Zone("Richman", new[] {647.50, -1118.20, -89.00, 787.40, -954.60, 110.90}),
            new Zone("Richman", new[] {647.50, -954.60, -89.00, 768.60, -860.60, 110.90}),
            new Zone("Richman", new[] {225.10, -1369.60, -89.00, 334.50, -1292.00, 110.90}),
            new Zone("Richman", new[] {225.10, -1292.00, -89.00, 466.20, -1235.00, 110.90}),
            new Zone("Richman", new[] {72.60, -1404.90, -89.00, 225.10, -1235.00, 110.90}),
            new Zone("Richman", new[] {72.60, -1235.00, -89.00, 321.30, -1008.10, 110.90}),
            new Zone("Richman", new[] {321.30, -1235.00, -89.00, 647.50, -1044.00, 110.90}),
            new Zone("Richman", new[] {321.30, -1044.00, -89.00, 647.50, -860.60, 110.90}),
            new Zone("Richman", new[] {321.30, -860.60, -89.00, 687.80, -768.00, 110.90}),
            new Zone("Richman", new[] {321.30, -768.00, -89.00, 700.70, -674.80, 110.90}),
            new Zone("Robada Intersection", new[] {-1119.00, 1178.90, -89.00, -862.00, 1351.40, 110.90}),
            new Zone("Roca Escalante", new[] {2237.40, 2202.70, -89.00, 2536.40, 2542.50, 110.90}),
            new Zone("Roca Escalante", new[] {2536.40, 2202.70, -89.00, 2625.10, 2442.50, 110.90}),
            new Zone("Rockshore East", new[] {2537.30, 676.50, -89.00, 2902.30, 943.20, 110.90}),
            new Zone("Rockshore West", new[] {1997.20, 596.30, -89.00, 2377.30, 823.20, 110.90}),
            new Zone("Rockshore West", new[] {2377.30, 596.30, -89.00, 2537.30, 788.80, 110.90}),
            new Zone("Rodeo", new[] {72.60, -1684.60, -89.00, 225.10, -1544.10, 110.90}),
            new Zone("Rodeo", new[] {72.60, -1544.10, -89.00, 225.10, -1404.90, 110.90}),
            new Zone("Rodeo", new[] {225.10, -1684.60, -89.00, 312.80, -1501.90, 110.90}),
            new Zone("Rodeo", new[] {225.10, -1501.90, -89.00, 334.50, -1369.60, 110.90}),
            new Zone("Rodeo", new[] {334.50, -1501.90, -89.00, 422.60, -1406.00, 110.90}),
            new Zone("Rodeo", new[] {312.80, -1684.60, -89.00, 422.60, -1501.90, 110.90}),
            new Zone("Rodeo", new[] {422.60, -1684.60, -89.00, 558.00, -1570.20, 110.90}),
            new Zone("Rodeo", new[] {558.00, -1684.60, -89.00, 647.50, -1384.90, 110.90}),
            new Zone("Rodeo", new[] {466.20, -1570.20, -89.00, 558.00, -1385.00, 110.90}),
            new Zone("Rodeo", new[] {422.60, -1570.20, -89.00, 466.20, -1406.00, 110.90}),
            new Zone("Rodeo", new[] {466.20, -1385.00, -89.00, 647.50, -1235.00, 110.90}),
            new Zone("Rodeo", new[] {334.50, -1406.00, -89.00, 466.20, -1292.00, 110.90}),
            new Zone("Royal Casino", new[] {2087.30, 1383.20, -89.00, 2437.30, 1543.20, 110.90}),
            new Zone("San Andreas Sound", new[] {2450.30, 385.50, -100.00, 2759.20, 562.30, 200.00}),
            new Zone("Santa Flora", new[] {-2741.00, 458.40, -7.60, -2533.00, 793.40, 200.00}),
            new Zone("Santa Maria Beach", new[] {342.60, -2173.20, -89.00, 647.70, -1684.60, 110.90}),
            new Zone("Santa Maria Beach", new[] {72.60, -2173.20, -89.00, 342.60, -1684.60, 110.90}),
            new Zone("Shady Cabin", new[] {-1632.80, -2263.40, -3.00, -1601.30, -2231.70, 200.00}),
            new Zone("Shady Creeks", new[] {-1820.60, -2643.60, -8.00, -1226.70, -1771.60, 200.00}),
            new Zone("Shady Creeks", new[] {-2030.10, -2174.80, -6.10, -1820.60, -1771.60, 200.00}),
            new Zone("Sobell Rail Yards", new[] {2749.90, 1548.90, -89.00, 2923.30, 1937.20, 110.90}),
            new Zone("Spinybed", new[] {2121.40, 2663.10, -89.00, 2498.20, 2861.50, 110.90}),
            new Zone("Starfish Casino", new[] {2437.30, 1783.20, -89.00, 2685.10, 2012.10, 110.90}),
            new Zone("Starfish Casino", new[] {2437.30, 1858.10, -39.00, 2495.00, 1970.80, 60.90}),
            new Zone("Starfish Casino", new[] {2162.30, 1883.20, -89.00, 2437.30, 2012.10, 110.90}),
            new Zone("Temple", new[] {1252.30, -1130.80, -89.00, 1378.30, -1026.30, 110.90}),
            new Zone("Temple", new[] {1252.30, -1026.30, -89.00, 1391.00, -926.90, 110.90}),
            new Zone("Temple", new[] {1252.30, -926.90, -89.00, 1357.00, -910.10, 110.90}),
            new Zone("Temple", new[] {952.60, -1130.80, -89.00, 1096.40, -937.10, 110.90}),
            new Zone("Temple", new[] {1096.40, -1130.80, -89.00, 1252.30, -1026.30, 110.90}),
            new Zone("Temple", new[] {1096.40, -1026.30, -89.00, 1252.30, -910.10, 110.90}),
            new Zone("The Camel's Toe", new[] {2087.30, 1203.20, -89.00, 2640.40, 1383.20, 110.90}),
            new Zone("The Clown's Pocket", new[] {2162.30, 1783.20, -89.00, 2437.30, 1883.20, 110.90}),
            new Zone("The Emerald Isle", new[] {2011.90, 2202.70, -89.00, 2237.40, 2508.20, 110.90}),
            new Zone("The Farm", new[] {-1209.60, -1317.10, 114.90, -908.10, -787.30, 251.90}),
            new Zone("The Four Dragons Casino", new[] {1817.30, 863.20, -89.00, 2027.30, 1083.20, 110.90}),
            new Zone("The High Roller", new[] {1817.30, 1283.20, -89.00, 2027.30, 1469.20, 110.90}),
            new Zone("The Mako Span", new[] {1664.60, 401.70, 0.00, 1785.10, 567.20, 200.00}),
            new Zone("The Panopticon", new[] {-947.90, -304.30, -1.10, -319.60, 327.00, 200.00}),
            new Zone("The Pink Swan", new[] {1817.30, 1083.20, -89.00, 2027.30, 1283.20, 110.90}),
            new Zone("The Sherman Dam", new[] {-968.70, 1929.40, -3.00, -481.10, 2155.20, 200.00}),
            new Zone("The Strip", new[] {2027.40, 863.20, -89.00, 2087.30, 1703.20, 110.90}),
            new Zone("The Strip", new[] {2106.70, 1863.20, -89.00, 2162.30, 2202.70, 110.90}),
            new Zone("The Strip", new[] {2027.40, 1783.20, -89.00, 2162.30, 1863.20, 110.90}),
            new Zone("The Strip", new[] {2027.40, 1703.20, -89.00, 2137.40, 1783.20, 110.90}),
            new Zone("The Visage", new[] {1817.30, 1863.20, -89.00, 2106.70, 2011.80, 110.90}),
            new Zone("The Visage", new[] {1817.30, 1703.20, -89.00, 2027.40, 1863.20, 110.90}),
            new Zone("Unity Station", new[] {1692.60, -1971.80, -20.40, 1812.60, -1932.80, 79.50}),
            new Zone("Valle Ocultado", new[] {-936.60, 2611.40, 2.00, -715.90, 2847.90, 200.00}),
            new Zone("Verdant Bluffs", new[] {930.20, -2488.40, -89.00, 1249.60, -2006.70, 110.90}),
            new Zone("Verdant Bluffs", new[] {1073.20, -2006.70, -89.00, 1249.60, -1842.20, 110.90}),
            new Zone("Verdant Bluffs", new[] {1249.60, -2179.20, -89.00, 1692.60, -1842.20, 110.90}),
            new Zone("Verdant Meadows", new[] {37.00, 2337.10, -3.00, 435.90, 2677.90, 200.00}),
            new Zone("Verona Beach", new[] {647.70, -2173.20, -89.00, 930.20, -1804.20, 110.90}),
            new Zone("Verona Beach", new[] {930.20, -2006.70, -89.00, 1073.20, -1804.20, 110.90}),
            new Zone("Verona Beach", new[] {851.40, -1804.20, -89.00, 1046.10, -1577.50, 110.90}),
            new Zone("Verona Beach", new[] {1161.50, -1722.20, -89.00, 1323.90, -1577.50, 110.90}),
            new Zone("Verona Beach", new[] {1046.10, -1722.20, -89.00, 1161.50, -1577.50, 110.90}),
            new Zone("Vinewood", new[] {787.40, -1310.20, -89.00, 952.60, -1130.80, 110.90}),
            new Zone("Vinewood", new[] {787.40, -1130.80, -89.00, 952.60, -954.60, 110.90}),
            new Zone("Vinewood", new[] {647.50, -1227.20, -89.00, 787.40, -1118.20, 110.90}),
            new Zone("Vinewood", new[] {647.70, -1416.20, -89.00, 787.40, -1227.20, 110.90}),
            new Zone("Whitewood Estates", new[] {883.30, 1726.20, -89.00, 1098.30, 2507.20, 110.90}),
            new Zone("Whitewood Estates", new[] {1098.30, 1726.20, -89.00, 1197.30, 2243.20, 110.90}),
            new Zone("Willowfield", new[] {1970.60, -2179.20, -89.00, 2089.00, -1852.80, 110.90}),
            new Zone("Willowfield", new[] {2089.00, -2235.80, -89.00, 2201.80, -1989.90, 110.90}),
            new Zone("Willowfield", new[] {2089.00, -1989.90, -89.00, 2324.00, -1852.80, 110.90}),
            new Zone("Willowfield", new[] {2201.80, -2095.00, -89.00, 2324.00, -1989.90, 110.90}),
            new Zone("Willowfield", new[] {2541.70, -1941.40, -89.00, 2703.50, -1852.80, 110.90}),
            new Zone("Willowfield", new[] {2324.00, -2059.20, -89.00, 2541.70, -1852.80, 110.90}),
            new Zone("Willowfield", new[] {2541.70, -2059.20, -89.00, 2703.50, -1941.40, 110.90}),
            new Zone("Yellow Bell Station", new[] {1377.40, 2600.40, -21.90, 1492.40, 2687.30, 78.00}),
            // Main Zones
            new Zone("Los Santos", new[] {44.60, -2892.90, -242.90, 2997.00, -768.00, 900.00}),
            new Zone("Las Venturas", new[] {869.40, 596.30, -242.90, 2997.00, 2993.80, 900.00}),
            new Zone("Bone County", new[] {-480.50, 596.30, -242.90, 869.40, 2993.80, 900.00}),
            new Zone("Tierra Robada", new[] {-2997.40, 1659.60, -242.90, -480.50, 2993.80, 900.00}),
            new Zone("Tierra Robada", new[] {-1213.90, 596.30, -242.90, -480.50, 1659.60, 900.00}),
            new Zone("San Fierro", new[] {-2997.40, -1115.50, -242.90, -1213.90, 1659.60, 900.00}),
            new Zone("Red County", new[] {-1213.90, -768.00, -242.90, 2997.00, 596.30, 900.00}),
            new Zone("Flint County", new[] {-1213.90, -2892.90, -242.90, 44.60, -768.00, 900.00}),
            new Zone("Whetstone", new[] {-2997.40, -2892.90, -242.90, -1213.90, -1115.50, 900.00})
        };

        #endregion

        public static string GetLocationName(double lx, double ly)
        {
            var zone = SanAndreasZones.FirstOrDefault(t => lx >= t.Points[0] && lx <= t.Points[3] &&
                                                           ly >= t.Points[1] && ly <= t.Points[4]);
            return zone == null ? String.Empty : zone.Name;
        }
    }
}