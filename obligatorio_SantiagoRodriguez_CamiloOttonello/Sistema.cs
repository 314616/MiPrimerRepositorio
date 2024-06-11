using obligatorio_SantiagoRodriguez_CamiloOttonello;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace obligatorio_SantiagoRodriguez_CamiloOttonello
{
    public class Sistema
    {
        private List<Potrero> potreros;
        private List<Empleado> empleados;
        private List<Animal> animales;
        private List<Vacuna> vacunas;
        private List<VacunaAplicada> vacunaciones;


        public Sistema()
        {
            potreros = new List<Potrero>();
            empleados = new List<Empleado>();
            animales = new List<Animal>();
            vacunas = new List<Vacuna>();
            vacunaciones = new List<VacunaAplicada>();
            PrecargaDatos();
            //precargaDat();
        }

        private void precargaDat()
        {
            Bovino b28 = new Bovino("SBB90909", TipoSexo.Hembra, "Nelore", new DateTime(2024, 1, 1), 5900, 6.7, 315, true, false, TipoAlimento.Pastura);
            animales.Add(b28);
        }
        private void PrecargaDatos()
        {
            //PEONES
            
            Peon p1 = new Peon("juan.perez@example.com", "BatmanURU", "Juan Perez", new DateTime(2023, 3, 15), true);
            empleados.Add(p1);

            Peon p2 = new Peon("maria.garcia@example.com", "SupermanARG", "Maria Garcia", new DateTime(2022, 6, 28), false);
            empleados.Add(p2);

            Peon p3 = new Peon("carlos.lopez@example.com", "SpidermanBRA", "Carlos Lopez", new DateTime(2024, 1, 10), true);
            empleados.Add(p3);

            Peon p4 = new Peon("laura.martinez@example.com", "IronmanCHI", "Laura Martinez", new DateTime(2023, 8, 5), false);
            empleados.Add(p4);

            Peon p5 = new Peon("diego.rodriguez@example.com", "HulkCOL", "Diego Rodriguez", new DateTime(2022, 12, 19), true);
            empleados.Add(p5);

            Peon p6 = new Peon("andrea.flores@example.com", "ThorPER", "Andrea Flores", new DateTime(2024, 4, 22), false);
            empleados.Add(p6);

            Peon p7 = new Peon("pedro.gomez@example.com", "CaptainAmericaECU", "Pedro Gomez", new DateTime(2023, 2, 9), true);
            empleados.Add(p7);

            Peon p8 = new Peon("ana.fernandez@example.com", "BlackWidowVEN", "Ana Fernandez", new DateTime(2022, 10, 31), false);
            empleados.Add(p8);

            Peon p9 = new Peon("javier.ruiz@example.com", "DoctorStrangeBOL", "Javier Ruiz", new DateTime(2024, 7, 14), true);
            empleados.Add(p9);

            Peon p10 = new Peon("silvia.lopez@example.com", "WolverinePAR", "Silvia Lopez", new DateTime(2023, 5, 30), false);
            empleados.Add(p10);
            

            //CAPATACES
            Capataz c1 = new Capataz("juan25@example.com", "AB482g9o", "Juan Martinez", new DateTime(2023, 1, 1), 10);
            empleados.Add(c1);

            Capataz c2 = new Capataz("pedro.garcia@example.com", "Gt5vD3W7", "Pedro García", new DateTime(2023, 2, 2), 20);
            empleados.Add(c2);

            //BOVINOS
            Bovino b1 = new Bovino("SBB45671", TipoSexo.Macho, "Angus", new DateTime(2023, 12, 5), 3200, 4, 180, false, false, TipoAlimento.Grano);
            animales.Add(b1);

            Bovino b2 = new Bovino("SBB12345", TipoSexo.Hembra, "Hereford", new DateTime(2023, 12, 6), 3300, 4.1, 185, true, false, TipoAlimento.Pastura);
            animales.Add(b2);

            Bovino b3 = new Bovino("SBB98765", TipoSexo.Macho, "Limousin", new DateTime(2023, 12, 7), 3400, 4.2, 190, false, true, TipoAlimento.Grano);
            animales.Add(b3);

            Bovino b4 = new Bovino("SBB54321", TipoSexo.Hembra, "Charolais", new DateTime(2023, 12, 8), 3500, 4.3, 195, true, true, TipoAlimento.Pastura);
            animales.Add(b4);

            Bovino b5 = new Bovino("SBB13579", TipoSexo.Macho, "Simmental", new DateTime(2023, 12, 9), 3600, 4.4, 200, false, false, TipoAlimento.Grano);
            animales.Add(b5);

            Bovino b6 = new Bovino("SBB24680", TipoSexo.Hembra, "Brahman", new DateTime(2023, 12, 10), 3700, 4.5, 205, true, false, TipoAlimento.Pastura);
            animales.Add(b6);

            Bovino b7 = new Bovino("SBB80246", TipoSexo.Macho, "Gyr", new DateTime(2023, 12, 11), 3800, 4.6, 210, false, true, TipoAlimento.Grano);
            animales.Add(b7);

            Bovino b8 = new Bovino("SBB97531", TipoSexo.Hembra, "Nelore", new DateTime(2023, 12, 12), 3900, 4.7, 215, true, true, TipoAlimento.Pastura);
            animales.Add(b8);

            Bovino b9 = new Bovino("SBB86420", TipoSexo.Macho, "Holstein", new DateTime(2023, 12, 13), 4000, 4.8, 220, false, false, TipoAlimento.Grano);
            animales.Add(b9);

            Bovino b10 = new Bovino("SBB36985", TipoSexo.Hembra, "Jersey", new DateTime(2023, 12, 14), 4100, 4.9, 225, true, false, TipoAlimento.Pastura);
            animales.Add(b10);

            Bovino b11 = new Bovino("SBB11111", TipoSexo.Macho, "Angus", new DateTime(2023, 12, 15), 4200, 5, 230, false, true, TipoAlimento.Grano);
            animales.Add(b11);

            Bovino b12 = new Bovino("SBB22222", TipoSexo.Hembra, "Hereford", new DateTime(2023, 12, 16), 4300, 5.1, 235, true, false, TipoAlimento.Pastura);
            animales.Add(b12);

            Bovino b13 = new Bovino("SBB33333", TipoSexo.Macho, "Limousin", new DateTime(2023, 12, 17), 4400, 5.2, 240, false, true, TipoAlimento.Grano);
            animales.Add(b13);

            Bovino b14 = new Bovino("SBB44444", TipoSexo.Hembra, "Charolais", new DateTime(2023, 12, 18), 4500, 5.3, 245, true, false, TipoAlimento.Pastura);
            animales.Add(b14);

            Bovino b15 = new Bovino("SBB55555", TipoSexo.Macho, "Simmental", new DateTime(2023, 12, 19), 4600, 5.4, 250, false, true, TipoAlimento.Grano);
            animales.Add(b15);

            Bovino b16 = new Bovino("SBB66666", TipoSexo.Hembra, "Brahman", new DateTime(2023, 12, 20), 4700, 5.5, 255, true, false, TipoAlimento.Pastura);
            animales.Add(b16);

            Bovino b17 = new Bovino("SBB77777", TipoSexo.Macho, "Gyr", new DateTime(2023, 12, 21), 4800, 5.6, 260, false, true, TipoAlimento.Grano);
            animales.Add(b17);

            Bovino b18 = new Bovino("SBB88888", TipoSexo.Hembra, "Nelore", new DateTime(2023, 12, 22), 4900, 5.7, 265, true, false, TipoAlimento.Pastura);
            animales.Add(b18);

            Bovino b19 = new Bovino("SBB99999", TipoSexo.Macho, "Holstein", new DateTime(2023, 12, 23), 5000, 5.8, 270, false, true, TipoAlimento.Grano);
            animales.Add(b19);

            Bovino b20 = new Bovino("SBB10101", TipoSexo.Hembra, "Jersey", new DateTime(2023, 12, 24), 5100, 5.9, 275, true, false, TipoAlimento.Pastura);
            animales.Add(b20);

            Bovino b21 = new Bovino("SBB20202", TipoSexo.Macho, "Angus", new DateTime(2023, 12, 25), 5200, 6, 280, false, true, TipoAlimento.Grano);
            animales.Add(b21);

            Bovino b22 = new Bovino("SBB30303", TipoSexo.Hembra, "Hereford", new DateTime(2023, 12, 26), 5300, 6.1, 285, true, false, TipoAlimento.Pastura);
            animales.Add(b22);

            Bovino b23 = new Bovino("SBB40404", TipoSexo.Macho, "Limousin", new DateTime(2023, 12, 27), 5400, 6.2, 290, false, true, TipoAlimento.Grano);
            animales.Add(b23);

            Bovino b24 = new Bovino("SBB50505", TipoSexo.Hembra, "Charolais", new DateTime(2023, 12, 28), 5500, 6.3, 295, true, false, TipoAlimento.Pastura);
            animales.Add(b24);

            Bovino b25 = new Bovino("SBB60606", TipoSexo.Macho, "Simmental", new DateTime(2023, 12, 29), 5600, 6.4, 300, false, true, TipoAlimento.Grano);
            animales.Add(b25);

            Bovino b26 = new Bovino("SBB70707", TipoSexo.Hembra, "Brahman", new DateTime(2023, 12, 30), 5700, 6.5, 305, true, false, TipoAlimento.Pastura);
            animales.Add(b26);

            Bovino b27 = new Bovino("SBB80808", TipoSexo.Macho, "Gyr", new DateTime(2023, 12, 31), 5800, 6.6, 310, false, true, TipoAlimento.Grano);
            animales.Add(b27);

            Bovino b28 = new Bovino("SBB90909", TipoSexo.Hembra, "Nelore", new DateTime(2024, 1, 1), 5900, 6.7, 315, true, false, TipoAlimento.Pastura);
            animales.Add(b28);

            Bovino b29 = new Bovino("SBB01010", TipoSexo.Macho, "Holstein", new DateTime(2024, 1, 2), 6000, 6.8, 320, false, true, TipoAlimento.Grano);
            animales.Add(b29);

            Bovino b30 = new Bovino("SBB01111", TipoSexo.Hembra, "Jersey", new DateTime(2024, 1, 3), 6100, 6.9, 325, true, false, TipoAlimento.Pastura);
            animales.Add(b30);

            // OVINOS 

            Ovino o1 = new Ovino("S1265J01", TipoSexo.Macho, "Pelibuey", new DateTime(2018, 12, 05), 2550, 4.8, 47, false, true, 4);
            animales.Add(o1);

            Ovino o2 = new Ovino("S2265J02", TipoSexo.Hembra, "Merino", new DateTime(2019, 03, 15), 2560, 4.9, 48, true, false, 4.1);
            animales.Add(o2);

            Ovino o3 = new Ovino("S3265J03", TipoSexo.Macho, "Dorper", new DateTime(2019, 07, 20), 2570, 5.0, 49, false, true, 4.2);
            animales.Add(o3);

            Ovino o4 = new Ovino("S4265J04", TipoSexo.Hembra, "Rambouillet", new DateTime(2020, 01, 10), 2580, 5.1, 50, true, false, 4.3);
            animales.Add(o4);

            Ovino o5 = new Ovino("S5265J05", TipoSexo.Macho, "Romney", new DateTime(2020, 05, 25), 2590, 5.2, 51, false, true, 4.4);
            animales.Add(o5);

            Ovino o6 = new Ovino("S6265J06", TipoSexo.Hembra, "Lincoln", new DateTime(2020, 09, 14), 2600, 5.3, 52, true, false, 4.5);
            animales.Add(o6);

            Ovino o7 = new Ovino("S7265J07", TipoSexo.Macho, "Suffolk", new DateTime(2021, 02, 07), 2610, 5.4, 53, false, true, 4.6);
            animales.Add(o7);

            Ovino o8 = new Ovino("S8265J08", TipoSexo.Hembra, "Cheviot", new DateTime(2021, 06, 18), 2620, 5.5, 54, true, false, 4.7);
            animales.Add(o8);

            Ovino o9 = new Ovino("S9265J09", TipoSexo.Macho, "Jacob", new DateTime(2021, 10, 03), 2630, 5.6, 55, false, true, 4.8);
            animales.Add(o9);

            Ovino o10 = new Ovino("S10265J10", TipoSexo.Hembra, "Cotswold", new DateTime(2022, 01, 29), 2640, 5.7, 56, true, false, 4.9);
            animales.Add(o10);

            Ovino o11 = new Ovino("S11265J11", TipoSexo.Macho, "Hampshire", new DateTime(2022, 05, 14), 2650, 5.8, 57, false, true, 5.0);
            animales.Add(o11);

            Ovino o12 = new Ovino("S12265J12", TipoSexo.Hembra, "Corriedale", new DateTime(2022, 09, 27), 2660, 5.9, 58, true, false, 5.1);
            animales.Add(o12);

            Ovino o13 = new Ovino("S13265J13", TipoSexo.Macho, "Columbia", new DateTime(2023, 01, 12), 2670, 6.0, 59, false, true, 5.2);
            animales.Add(o13);

            Ovino o14 = new Ovino("S14265J14", TipoSexo.Hembra, "Targhee", new DateTime(2023, 05, 05), 2680, 6.1, 60, true, false, 5.3);
            animales.Add(o14);

            Ovino o15 = new Ovino("S15265J15", TipoSexo.Macho, "Polwarth", new DateTime(2023, 09, 20), 2690, 6.2, 61, false, true, 5.4);
            animales.Add(o15);

            Ovino o16 = new Ovino("S16265J16", TipoSexo.Hembra, "Black Welsh Mountain", new DateTime(2024, 01, 03), 2700, 6.3, 62, true, false, 5.5);
            animales.Add(o16);

            Ovino o17 = new Ovino("S17265J17", TipoSexo.Macho, "Shropshire", new DateTime(2024, 05, 17), 2710, 6.4, 63, false, true, 5.6);
            animales.Add(o17);

            Ovino o18 = new Ovino("S18265J18", TipoSexo.Hembra, "Bluefaced Leicester", new DateTime(2024, 09, 30), 2720, 6.5, 64, true, false, 5.7);
            animales.Add(o18);

            Ovino o19 = new Ovino("S19265J19", TipoSexo.Macho, "North Ronaldsay", new DateTime(2018, 02, 15), 2730, 6.6, 65, false, true, 5.8);
            animales.Add(o19);

            Ovino o20 = new Ovino("S20265J20", TipoSexo.Hembra, "Devon Longwool", new DateTime(2018, 06, 25), 2740, 6.7, 66, true, false, 5.9);
            animales.Add(o20);

            Ovino o21 = new Ovino("S21265J21", TipoSexo.Macho, "Karakul", new DateTime(2018, 10, 10), 2750, 6.8, 67, false, true, 6.0);
            animales.Add(o21);

            Ovino o22 = new Ovino("S22265J22", TipoSexo.Hembra, "Navajo-Churro", new DateTime(2019, 01, 23), 2760, 6.9, 68, true, false, 6.1);
            animales.Add(o22);

            Ovino o23 = new Ovino("S23265J23", TipoSexo.Macho, "Scottish Blackface", new DateTime(2019, 05, 07), 2770, 7.0, 69, false, true, 6.2);
            animales.Add(o23);

            Ovino o24 = new Ovino("S24265J24", TipoSexo.Hembra, "Merinolandschaf", new DateTime(2019, 09, 20), 2780, 7.1, 70, true, false, 6.3);
            animales.Add(o24);

            Ovino o25 = new Ovino("S25265J25", TipoSexo.Macho, "Swaledale", new DateTime(2020, 02, 05), 2790, 7.2, 71, false, true, 6.4);
            animales.Add(o25);

            Ovino o26 = new Ovino("S26265J26", TipoSexo.Hembra, "Ouessant", new DateTime(2020, 06, 17), 2800, 7.3, 72, true, false, 6.5);
            animales.Add(o26);

            Ovino o27 = new Ovino("S27265J27", TipoSexo.Macho, "Texel", new DateTime(2020, 10, 02), 2810, 7.4, 73, false, true, 6.6);
            animales.Add(o27);

            Ovino o28 = new Ovino("S28265J28", TipoSexo.Hembra, "Hog Island", new DateTime(2021, 01, 15), 2820, 7.5, 74, true, false, 6.7);
            animales.Add(o28);

            Ovino o29 = new Ovino("S29265J29", TipoSexo.Macho, "Cormo", new DateTime(2021, 05, 30), 2830, 7.6, 75, false, true, 6.8);
            animales.Add(o29);

            Ovino o30 = new Ovino("S30265J30", TipoSexo.Hembra, "Solognote", new DateTime(2021, 09, 12), 2840, 7.7, 76, true, false, 6.9);
            animales.Add(o30);

            //POTREROS 
            Potrero po1 = new Potrero("El terreno es ondulado, pasa un arroyo por el medio", 700, 1050);
            potreros.Add(po1); // Agregar po1 a la lista de potreros

            Potrero po2 = new Potrero("El terreno es llano, con algunos árboles dispersos", 500, 750);
            potreros.Add(po2);

            Potrero po3 = new Potrero("Terreno montañoso, con abundante vegetación", 800, 1200);
            potreros.Add(po3);

            Potrero po4 = new Potrero("Terreno con suave pendiente, con pastizales altos", 600, 900);
            potreros.Add(po4);

            Potrero po5 = new Potrero("Terreno rocoso con escasa vegetación", 400, 600);
            potreros.Add(po5);

            Potrero po6 = new Potrero("Terreno con zonas pantanosas y otras secas", 900, 1350);
            potreros.Add(po6);

            Potrero po7 = new Potrero("Terreno con densa arboleda y pastizales", 750, 1125);
            potreros.Add(po7);

            Potrero po8 = new Potrero("Terreno plano con cercas perimetrales", 550, 825);
            potreros.Add(po8);

            Potrero po9 = new Potrero("Terreno con afloramientos rocosos y pastos bajos", 650, 975);
            potreros.Add(po9);

            Potrero po10 = new Potrero("Terreno con áreas cultivadas y agua corriente", 850, 1275);
            potreros.Add(po10);

            // VACUNAS 

            Vacuna v1 = new Vacuna("Bovilis Bovipast RSP", "Vacuna contra la rinotraqueitis infecciosa bovina (IBR) y la enfermedad respiratoria sincitial bovina (BRSV).", "Virus");
            vacunas.Add(v1);

            Vacuna v2 = new Vacuna("Covexin 10", "Vacuna polivalente contra la clostridiosis en ovinos y bovinos.", "Bacterias del género Clostridium");
            vacunas.Add(v2);

            Vacuna v3 = new Vacuna("Toxovax", "Vacuna contra la toxoplasmosis en ovejas.", "Parásito Toxoplasma gondii");
            vacunas.Add(v3);

            Vacuna v4 = new Vacuna("Bravoxin 10", "Vacuna contra la fiebre aftosa en bovinos.", "Virus de la fiebre aftosa");
            vacunas.Add(v4);

            Vacuna v5 = new Vacuna("Gudair", "Vacuna contra la paratuberculosis en ovinos.", "Bacteria Mycobacterium avium subsp. paratuberculosis");
            vacunas.Add(v5);

            Vacuna v6 = new Vacuna("Spirovac", "Vacuna contra la leptospirosis en bovinos.", "Bacteria del género Leptospira");
            vacunas.Add(v6);

            Vacuna v7 = new Vacuna("Footvax", "Vacuna contra la fiebre catarral ovina (lengua azul) en ovinos.", "Virus de la lengua azul");
            vacunas.Add(v7);

            Vacuna v8 = new Vacuna("Bovilis IBR Marker Inativado", "Vacuna inactivada contra la rinotraqueitis infecciosa bovina (IBR) en bovinos.", "Virus");
            vacunas.Add(v8);

            Vacuna v9 = new Vacuna("Ovilis Enzovax", "Vacuna contra la enterotoxemia en ovinos.", "Bacterias del género Clostridium");
            vacunas.Add(v9);

            Vacuna v10 = new Vacuna("Scabivax Forte", "Vacuna contra la sarna sarcóptica en ovinos.", "Ácaro Sarcoptes scabiei");
            vacunas.Add(v10);

            //TAREAS 


            
            Tarea t1 = new Tarea("Alimentar cerdos", new DateTime(2024, 05, 02), new DateTime(1111, 11, 11), false, "", c1);
            p1.tareas.Add(t1);

            Tarea t2 = new Tarea("Sembrar maíz", new DateTime(2024, 05, 05), new DateTime(2024, 05, 05), true, "Tarea completada correctamente", c2);
            p1.tareas.Add(t2);

            Tarea t3 = new Tarea("Reparar cercas", new DateTime(2024, 05, 10), new DateTime(2024, 05, 09), true, "Reparaciones finalizadas", c1);
            p1.tareas.Add(t3);

            Tarea t4 = new Tarea("Ordenar el granero", new DateTime(2024, 05, 15), new DateTime(1111, 11, 11), false, "", c2);
            p1.tareas.Add(t4);

            Tarea t5 = new Tarea("Plantar patatas", new DateTime(2024, 05, 18), new DateTime(2024, 05, 18), true, "Siembra finalizada", c1);
            p1.tareas.Add(t5);

            Tarea t6 = new Tarea("Cosechar trigo", new DateTime(2024, 05, 22), new DateTime(1111, 11, 11), false, "", c2);
            p1.tareas.Add(t6);

            Tarea t7 = new Tarea("Ordeñar vacas", new DateTime(2024, 05, 25), new DateTime(2024, 05, 25), true, "Ordeño completado", c1);
            p1.tareas.Add(t7);

            Tarea t8 = new Tarea("Podar árboles", new DateTime(2024, 05, 28), new DateTime(2024, 05, 27), true, "Podas finalizadas", c2);
            p1.tareas.Add(t8);

            Tarea t9 = new Tarea("Arar campos", new DateTime(2024, 06, 01), new DateTime(1111, 11, 11), false, "", c1);
            p1.tareas.Add(t9);

            Tarea t10 = new Tarea("Fertilizar tierras", new DateTime(2024, 06, 05), new DateTime(1111, 11, 11), false, "", c2);
            p1.tareas.Add(t10);

            Tarea t11 = new Tarea("Controlar plagas", new DateTime(2024, 06, 10), new DateTime(1111, 11, 11), false, "", c1);
            p1.tareas.Add(t11);

            Tarea t12 = new Tarea("Regar huertos", new DateTime(2024, 06, 15), new DateTime(1111, 11, 11), false, "", c2);
            p1.tareas.Add(t12);

            Tarea t13 = new Tarea("Recolectar frutas", new DateTime(2024, 06, 20), new DateTime(2024, 06, 20), true, "Recolección terminada", c1);
            p1.tareas.Add(t13);

            Tarea t14 = new Tarea("Limpiar establos", new DateTime(2024, 06, 25), new DateTime(1111, 11, 11), false, "", c2);
            p1.tareas.Add(t14);

            Tarea t15 = new Tarea("Revisar maquinaria", new DateTime(2024, 06, 30), new DateTime(2024, 06, 30), true, "Revisión completada", c1);
            p1.tareas.Add(t15);

            Tarea t16 = new Tarea("Fertilizar tierras", new DateTime(2024, 06, 05), new DateTime(1111, 11, 11), false, "", c2);
            p2.tareas.Add(t16);

            Tarea t17 = new Tarea("Controlar plagas", new DateTime(2024, 06, 10), new DateTime(1111, 11, 11), false, "", c1);
            p2.tareas.Add(t17);

            Tarea t18 = new Tarea("Regar huertos", new DateTime(2024, 06, 15), new DateTime(1111, 11, 11), false, "", c2);
            p2.tareas.Add(t18);

            Tarea t19 = new Tarea("Recolectar frutas", new DateTime(2024, 06, 20), new DateTime(2024, 06, 20), true, "Recolección terminada", c1);
            p2.tareas.Add(t19);

            Tarea t20 = new Tarea("Limpiar establos", new DateTime(2024, 06, 25), new DateTime(1111, 11, 11), false, "", c2);
            p2.tareas.Add(t20);

            Tarea t21 = new Tarea("Revisar maquinaria", new DateTime(2024, 06, 30), new DateTime(2024, 06, 30), true, "Revisión completada", c1);
            p2.tareas.Add(t21);

            Tarea t22 = new Tarea("Podar setos", new DateTime(2024, 07, 05), new DateTime(1111, 11, 11), false, "", c2);
            p2.tareas.Add(t22);

            Tarea t23 = new Tarea("Arar huertos", new DateTime(2024, 07, 10), new DateTime(2024, 07, 10), true, "Labores de arado finalizadas", c1);
            p2.tareas.Add(t23);

            Tarea t24 = new Tarea("Recolectar huevos", new DateTime(2024, 07, 15), new DateTime(1111, 11, 11), false, "", c2);
            p2.tareas.Add(t24);

            Tarea t25 = new Tarea("Revisar cercas", new DateTime(2024, 07, 20), new DateTime(2024, 07, 20), true, "Inspección de cercas completada", c1);
            p2.tareas.Add(t25);

            Tarea t26 = new Tarea("Limpiar granero", new DateTime(2024, 07, 25), new DateTime(1111, 11, 11), false, "", c2);
            p2.tareas.Add(t26);

            Tarea t27 = new Tarea("Sembrar lechugas", new DateTime(2024, 08, 01), new DateTime(2024, 08, 01), true, "Siembra de lechugas realizada", c1);
            p2.tareas.Add(t27);
    
            Tarea t28 = new Tarea("Ordeñar cabras", new DateTime(2024, 08, 05), new DateTime(1111, 11, 11), false, "", c2);
            p2.tareas.Add(t28);

            Tarea t29 = new Tarea("Cosechar manzanas", new DateTime(2024, 08, 10), new DateTime(2024, 08, 10), true, "Cosecha de manzanas completada", c1);
            p2.tareas.Add(t29);

            Tarea t30 = new Tarea("Fertilizar campos", new DateTime(2024, 08, 15), new DateTime(1111, 11, 11), false, "", c2);
            p3.tareas.Add(t30);

            Tarea t31 = new Tarea("Podar árboles frutales", new DateTime(2024, 08, 20), new DateTime(2024, 08, 20), true, "Podas de árboles realizadas", c1);
            p3.tareas.Add(t31);

            Tarea t32 = new Tarea("Controlar malezas", new DateTime(2024, 08, 25), new DateTime(1111, 11, 11), false, "", c2);
            p3.tareas.Add(t32);

            Tarea t33 = new Tarea("Revisar establos", new DateTime(2024, 09, 01), new DateTime(2024, 09, 01), true, "Inspección de establos completada", c1);
            p3.tareas.Add(t33);

            Tarea t34 = new Tarea("Sembrar girasoles", new DateTime(2024, 09, 05), new DateTime(1111, 11, 11), false, "", c2);
            p3.tareas.Add(t34);

            Tarea t35 = new Tarea("Cuidar ganado", new DateTime(2024, 09, 10), new DateTime(1111, 11, 11), false, "", c1);
            p3.tareas.Add(t35);

            Tarea t36 = new Tarea("Podar viñedos", new DateTime(2024, 09, 15), new DateTime(2024, 09, 15), true, "Podas de viñedos realizadas", c2);
            p3.tareas.Add(t36);

            Tarea t37 = new Tarea("Sembrar zanahorias", new DateTime(2024, 09, 20), new DateTime(2024, 09, 20), true, "Siembra de zanahorias completada", c1);
            p3.tareas.Add(t37);

            Tarea t38 = new Tarea("Fertilizar cultivos", new DateTime(2024, 09, 25), new DateTime(1111, 11, 11), false, "", c2);
            p3.tareas.Add(t38);

            Tarea t39 = new Tarea("Recolectar maíz", new DateTime(2024, 10, 01), new DateTime(1111, 11, 11), false, "", c1);
            p3.tareas.Add(t39);

            Tarea t40 = new Tarea("Controlar plagas", new DateTime(2024, 10, 05), new DateTime(1111, 11, 11), false, "", c2);
            p3.tareas.Add(t40);

            Tarea t41 = new Tarea("Arar campos", new DateTime(2024, 10, 10), new DateTime(2024, 10, 10), true, "Labores de arado finalizadas", c1);
            p3.tareas.Add(t41);

            Tarea t42 = new Tarea("Sembrar papas", new DateTime(2024, 10, 15), new DateTime(1111, 11, 11), false, "", c2);
            p3.tareas.Add(t42);

            Tarea t43 = new Tarea("Regar plantaciones", new DateTime(2024, 10, 20), new DateTime(1111, 11, 11), false, "", c1);
            p3.tareas.Add(t43);
    
            Tarea t44 = new Tarea("Podar rosales", new DateTime(2024, 10, 25), new DateTime(2024, 10, 25), true, "Podas de rosales realizadas", c2);
            p3.tareas.Add(t44);

            Tarea t45 = new Tarea("Recolectar frutas", new DateTime(2024, 10, 30), new DateTime(1111, 11, 11), false, "", c1);
            p4.tareas.Add(t45);

            Tarea t46 = new Tarea("Limpiar granero", new DateTime(2024, 11, 05), new DateTime(2024, 11, 05), true, "Limpienza de granero completada", c2);
            p4.tareas.Add(t46);

            Tarea t47 = new Tarea("Sembrar calabazas", new DateTime(2024, 11, 10), new DateTime(2024, 11, 10), true, "Siembra de calabazas realizada", c1);
            p4.tareas.Add(t47);

            Tarea t48 = new Tarea("Cuidar pollos", new DateTime(2024, 11, 15), new DateTime(1111, 11, 11), false, "", c2);
            p4.tareas.Add(t48);

            Tarea t49 = new Tarea("Fertilizar huertos", new DateTime(2024, 11, 20), new DateTime(1111, 11, 11), false, "", c1);
            p4.tareas.Add(t49);

            Tarea t50 = new Tarea("Revisar vallas", new DateTime(2024, 11, 25), new DateTime(1111, 11, 11), false, "", c2);
            p4.tareas.Add(t50);

            Tarea t51 = new Tarea("Ordeñar vacas", new DateTime(2024, 12, 01), new DateTime(2024, 12, 01), true, "Ordeño de vacas realizado", c1);
            p4.tareas.Add(t51);

            Tarea t52 = new Tarea("Podar arbustos", new DateTime(2024, 12, 05), new DateTime(2024, 12, 05), true, "Podas de arbustos realizadas", c2);
            p4.tareas.Add(t52);

            Tarea t53 = new Tarea("Sembrar fresas", new DateTime(2024, 12, 10), new DateTime(1111, 11, 11), false, "", c1);
            p4.tareas.Add(t53);

            Tarea t54 = new Tarea("Regar jardines", new DateTime(2024, 12, 15), new DateTime(1111, 11, 11), false, "", c2);
            p4.tareas.Add(t54);

            Tarea t55 = new Tarea("Cosechar calabazas", new DateTime(2024, 12, 20), new DateTime(2024, 12, 20), true, "Cosecha de calabazas completada", c1);
            p4.tareas.Add(t55);

            Tarea t56 = new Tarea("Fertilizar campos", new DateTime(2024, 12, 25), new DateTime(1111, 11, 11), false, "", c2);
            p4.tareas.Add(t56);

            Tarea t57 = new Tarea("Revisar cercas", new DateTime(2025, 01, 01), new DateTime(2025, 01, 01), true, "Inspección de cercas completada", c1);
            p4.tareas.Add(t57);

            Tarea t58 = new Tarea("Sembrar lechugas", new DateTime(2025, 01, 05), new DateTime(2025, 01, 05), true, "Siembra de lechugas realizada", c2);
            p4.tareas.Add(t58);

            Tarea t59 = new Tarea("Limpiar establos", new DateTime(2025, 01, 10), new DateTime(1111, 11, 11), false, "", c1);
            p4.tareas.Add(t59);

            Tarea t60 = new Tarea("Recolectar huevos", new DateTime(2025, 01, 15), new DateTime(1111, 11, 11), false, "", c2);
            p5.tareas.Add(t60);

            Tarea t61 = new Tarea("Controlar malezas", new DateTime(2025, 01, 20), new DateTime(1111, 11, 11), false, "", c1);
            p5.tareas.Add(t61);

            Tarea t62 = new Tarea("Arar campos", new DateTime(2025, 01, 25), new DateTime(2025, 01, 25), true, "Labores de arado finalizadas", c2);
            p5.tareas.Add(t62);

            Tarea t63 = new Tarea("Sembrar papas", new DateTime(2025, 02, 01), new DateTime(2025, 02, 01), true, "Siembra de papas realizada", c1);
            p5.tareas.Add(t63);

            Tarea t64 = new Tarea("Regar plantaciones", new DateTime(2025, 02, 05), new DateTime(1111, 11, 11), false, "", c2);
            p5.tareas.Add(t64);

            Tarea t65 = new Tarea("Podar rosales", new DateTime(2025, 02, 10), new DateTime(2025, 02, 10), true, "Podas de rosales realizadas", c1);
            p5.tareas.Add(t65);

            Tarea t66 = new Tarea("Recolectar frutas", new DateTime(2025, 02, 15), new DateTime(1111, 11, 11), false, "", c2);
            p5.tareas.Add(t66);

            Tarea t67 = new Tarea("Limpiar granero", new DateTime(2025, 02, 20), new DateTime(1111, 11, 11), false, "", c1);
            p5.tareas.Add(t67);

            Tarea t68 = new Tarea("Sembrar calabazas", new DateTime(2025, 02, 25), new DateTime(1111, 11, 11), false, "", c2);
            p5.tareas.Add(t68);

            Tarea t69 = new Tarea("Cuidar pollos", new DateTime(2025, 03, 01), new DateTime(2025, 03, 01), true, "Cuidado de pollos completado", c1);
            p5.tareas.Add(t69);

            Tarea t70 = new Tarea("Fertilizar huertos", new DateTime(2025, 03, 05), new DateTime(1111, 11, 11), false, "", c2);
            p5.tareas.Add(t70);

            Tarea t71 = new Tarea("Revisar vallas", new DateTime(2025, 03, 10), new DateTime(1111, 11, 11), false, "", c1);
            p5.tareas.Add(t71);

            Tarea t72 = new Tarea("Ordeñar vacas", new DateTime(2025, 03, 15), new DateTime(2025, 03, 15), true, "Ordeño de vacas realizado", c2);
            p5.tareas.Add(t72);

            Tarea t73 = new Tarea("Podar arbustos", new DateTime(2025, 03, 20), new DateTime(1111, 11, 11), false, "", c1);
            p5.tareas.Add(t73);

            Tarea t74 = new Tarea("Sembrar fresas", new DateTime(2025, 03, 25), new DateTime(1111, 11, 11), false, "", c2);
            p5.tareas.Add(t74);

            Tarea t75 = new Tarea("Regar jardines", new DateTime(2025, 04, 01), new DateTime(1111, 11, 11), false, "", c1);
            p6.tareas.Add(t75);

            Tarea t76 = new Tarea("Cosechar calabazas", new DateTime(2025, 04, 05), new DateTime(2025, 04, 05), true, "Cosecha de calabazas completada", c2);
            p6.tareas.Add(t76);

            Tarea t77 = new Tarea("Fertilizar campos", new DateTime(2025, 04, 10), new DateTime(1111, 11, 11), false, "", c1);
            p6.tareas.Add(t77);

            Tarea t78 = new Tarea("Revisar cercas", new DateTime(2025, 04, 15), new DateTime(2025, 04, 15), true, "Inspección de cercas completada", c2);
            p6.tareas.Add(t78);

            Tarea t79 = new Tarea("Sembrar lechugas", new DateTime(2025, 04, 20), new DateTime(2025, 04, 20), true, "Siembra de lechugas realizada", c1);
            p6.tareas.Add(t79);
    
            Tarea t80 = new Tarea("Limpiar establos", new DateTime(2025, 04, 25), new DateTime(1111, 11, 11), false, "", c2);
            p6.tareas.Add(t80);

            Tarea t81 = new Tarea("Recolectar huevos", new DateTime(2025, 05, 01), new DateTime(1111, 11, 11), false, "", c1);
            p6.tareas.Add(t81);

            Tarea t82 = new Tarea("Controlar malezas", new DateTime(2025, 05, 05), new DateTime(2025, 05, 05), true, "Control de malezas completado", c2);
            p6.tareas.Add(t82);

            Tarea t83 = new Tarea("Arar campos", new DateTime(2025, 05, 10), new DateTime(1111, 11, 11), false, "", c1);
            p6.tareas.Add(t83);

            Tarea t84 = new Tarea("Sembrar papas", new DateTime(2025, 05, 15), new DateTime(2025, 05, 15), true, "Siembra de papas realizada", c2);
            p6.tareas.Add(t84);

            Tarea t85 = new Tarea("Regar plantaciones", new DateTime(2025, 05, 20), new DateTime(1111, 11, 11), false, "", c1);
            p6.tareas.Add(t85);

            Tarea t86 = new Tarea("Podar rosales", new DateTime(2025, 05, 25), new DateTime(1111, 11, 11), false, "", c2);
            p6.tareas.Add(t86);

            Tarea t87 = new Tarea("Recolectar frutas", new DateTime(2025, 06, 01), new DateTime(1111, 11, 11), false, "", c1);
            p6.tareas.Add(t87);

            Tarea t88 = new Tarea("Limpiar granero", new DateTime(2025, 06, 05), new DateTime(2025, 06, 05), true, "Limpienza de granero completada", c2);
            p6.tareas.Add(t88);

            Tarea t89 = new Tarea("Sembrar calabazas", new DateTime(2025, 06, 10), new DateTime(1111, 11, 11), false, "", c1);
            p6.tareas.Add(t89);

            Tarea t91 = new Tarea("Fertilizar huertos", new DateTime(2025, 06, 20), new DateTime(1111, 11, 11), false, "", c1);
            p7.tareas.Add(t91);

            Tarea t92 = new Tarea("Revisar vallas", new DateTime(2025, 06, 25), new DateTime(1111, 11, 11), false, "", c2);
            p7.tareas.Add(t92);

            Tarea t93 = new Tarea("Ordeñar vacas", new DateTime(2025, 07, 01), new DateTime(2025, 07, 01), true, "Ordeño de vacas realizado", c1);
            p7.tareas.Add(t93);

            Tarea t94 = new Tarea("Podar arbustos", new DateTime(2025, 07, 05), new DateTime(1111, 11, 11), false, "", c2);
            p7.tareas.Add(t94);

            Tarea t95 = new Tarea("Sembrar fresas", new DateTime(2025, 07, 10), new DateTime(1111, 11, 11), false, "", c1);
            p7.tareas.Add(t95);

            Tarea t96 = new Tarea("Regar jardines", new DateTime(2025, 07, 15), new DateTime(1111, 11, 11), false, "", c2);
            p7.tareas.Add(t96);

            Tarea t97 = new Tarea("Cosechar calabazas", new DateTime(2025, 07, 20), new DateTime(1111, 11, 11), false, "", c1);
            p7.tareas.Add(t97);

            Tarea t98 = new Tarea("Fertilizar campos", new DateTime(2025, 07, 25), new DateTime(2025, 07, 25), true, "Fertilización de campos completada", c2);
            p7.tareas.Add(t98);

            Tarea t99 = new Tarea("Revisar cercas", new DateTime(2025, 08, 01), new DateTime(1111, 11, 11), false, "", c1);
            p7.tareas.Add(t99);

            Tarea t100 = new Tarea("Sembrar lechugas", new DateTime(2025, 08, 05), new DateTime(2025, 08, 05), true, "Siembra de lechugas realizada", c2);
            p7.tareas.Add(t100);

            Tarea t101 = new Tarea("Limpiar establos", new DateTime(2025, 08, 10), new DateTime(1111, 11, 11), false, "", c1);
            p7.tareas.Add(t101);

            Tarea t102 = new Tarea("Recolectar huevos", new DateTime(2025, 08, 15), new DateTime(2025, 08, 15), true, "Recolección de huevos completada", c2);
            p7.tareas.Add(t102);

            Tarea t103 = new Tarea("Controlar malezas", new DateTime(2025, 08, 20), new DateTime(1111, 11, 11), false, "", c1);
            p7.tareas.Add(t103);

            Tarea t104 = new Tarea("Arar campos", new DateTime(2025, 08, 25), new DateTime(2025, 08, 25), true, "Labores de arado finalizadas", c2);
            p7.tareas.Add(t104);

            Tarea t105 = new Tarea("Sembrar papas", new DateTime(2025, 09, 01), new DateTime(1111, 11, 11), false, "", c1);
            p8.tareas.Add(t105);

            Tarea t106 = new Tarea("Regar plantaciones", new DateTime(2025, 09, 05), new DateTime(1111, 11, 11), false, "", c2);
            p8.tareas.Add(t106);

            Tarea t107 = new Tarea("Podar rosales", new DateTime(2025, 09, 10), new DateTime(1111, 11, 11), false, "", c1);
            p8.tareas.Add(t107);

            Tarea t108 = new Tarea("Recolectar frutas", new DateTime(2025, 09, 15), new DateTime(2025, 09, 15), true, "Recolección de frutas completada", c2);
            p8.tareas.Add(t108);

            Tarea t109 = new Tarea("Limpiar granero", new DateTime(2025, 09, 20), new DateTime(1111, 11, 11), false, "", c1);
            p8.tareas.Add(t109);

            Tarea t110 = new Tarea("Sembrar calabazas", new DateTime(2025, 09, 25), new DateTime(2025, 09, 25), true, "Siembra de calabazas realizada", c2);
            p8.tareas.Add(t110);

            Tarea t111 = new Tarea("Cuidar pollos", new DateTime(2025, 10, 01), new DateTime(1111, 11, 11), false, "", c1);
            p8.tareas.Add(t111);

            Tarea t112 = new Tarea("Fertilizar huertos", new DateTime(2025, 10, 05), new DateTime(1111, 11, 11), false, "", c2);
            p8.tareas.Add(t112);

            Tarea t113 = new Tarea("Revisar vallas", new DateTime(2025, 10, 10), new DateTime(2025, 10, 10), true, "Inspección de vallas completada", c1);
            p8.tareas.Add(t113);

            Tarea t114 = new Tarea("Ordeñar vacas", new DateTime(2025, 10, 15), new DateTime(1111, 11, 11), false, "", c2);
            p8.tareas.Add(t114);

            Tarea t115 = new Tarea("Podar arbustos", new DateTime(2025, 10, 20), new DateTime(1111, 11, 11), false, "", c1);
            p8.tareas.Add(t115);

            Tarea t116 = new Tarea("Sembrar fresas", new DateTime(2025, 10, 25), new DateTime(2025, 10, 25), true, "Siembra de fresas realizada", c2);
            p8.tareas.Add(t116);

            Tarea t117 = new Tarea("Regar jardines", new DateTime(2025, 11, 01), new DateTime(1111, 11, 11), false, "", c1);
            p8.tareas.Add(t117);

            Tarea t118 = new Tarea("Cosechar calabazas", new DateTime(2025, 11, 05), new DateTime(1111, 11, 11), false, "", c2);
            p8.tareas.Add(t118);

            Tarea t119 = new Tarea("Fertilizar campos", new DateTime(2025, 11, 10), new DateTime(2025, 11, 10), true, "Fertilización de campos completada", c1);
            p8.tareas.Add(t119);

            Tarea t120 = new Tarea("Revisar cercas", new DateTime(2025, 11, 15), new DateTime(1111, 11, 11), false, "", c2);
            p9.tareas.Add(t120);

            Tarea t121 = new Tarea("Sembrar lechugas", new DateTime(2026, 03, 05), new DateTime(1111, 11, 11), false, "", c1);
            p9.tareas.Add(t121);

            Tarea t122 = new Tarea("Limpiar establos", new DateTime(2026, 03, 10), new DateTime(1111, 11, 11), false, "", c2);
            p9.tareas.Add(t122);

            Tarea t123 = new Tarea("Recolectar huevos", new DateTime(2026, 03, 15), new DateTime(1111, 11, 11), false, "", c1);
            p9.tareas.Add(t123);

            Tarea t124 = new Tarea("Controlar malezas", new DateTime(2026, 03, 20), new DateTime(2026, 03, 20), true, "Malezas controladas", c2);
            p9.tareas.Add(t124);

            Tarea t125 = new Tarea("Arar campos", new DateTime(2026, 03, 25), new DateTime(1111, 11, 11), false, "", c1);
            p9.tareas.Add(t125);

            Tarea t126 = new Tarea("Sembrar papas", new DateTime(2026, 04, 01), new DateTime(1111, 11, 11), false, "", c2);
            p9.tareas.Add(t126);

            Tarea t127 = new Tarea("Regar plantaciones", new DateTime(2026, 04, 05), new DateTime(2026, 04, 05), true, "Plantaciones regadas", c1);
            p9.tareas.Add(t127);

            Tarea t128 = new Tarea("Podar rosales", new DateTime(2026, 04, 10), new DateTime(1111, 11, 11), false, "", c2);
            p9.tareas.Add(t128);

            Tarea t129 = new Tarea("Recolectar frutas", new DateTime(2026, 04, 15), new DateTime(1111, 11, 11), false, "", c1);
            p9.tareas.Add(t129);

            Tarea t130 = new Tarea("Limpiar granero", new DateTime(2026, 04, 20), new DateTime(1111, 11, 11), false, "", c2);
            p9.tareas.Add(t130);


            Tarea t131 = new Tarea("Sembrar calabazas", new DateTime(2026, 04, 25), new DateTime(1111, 11, 11), false, "", c1);
            p9.tareas.Add(t131);

            Tarea t132 = new Tarea("Cuidar pollos", new DateTime(2026, 05, 01), new DateTime(2026, 05, 01), true, "Pollos cuidados", c2);
            p9.tareas.Add(t132);

            Tarea t133 = new Tarea("Fertilizar huertos", new DateTime(2026, 05, 05), new DateTime(1111, 11, 11), false, "", c1);
            p9.tareas.Add(t133);

            Tarea t134 = new Tarea("Revisar vallas", new DateTime(2026, 05, 10), new DateTime(1111, 11, 11), false, "", c2);
            p9.tareas.Add(t134);

            Tarea t135 = new Tarea("Ordeñar vacas", new DateTime(2026, 05, 15), new DateTime(1111, 11, 11), false, "", c1);
            p10.tareas.Add(t135);

            Tarea t136 = new Tarea("Podar arbustos", new DateTime(2026, 05, 20), new DateTime(2026, 05, 20), true, "Arbustos podados", c2);
            p10.tareas.Add(t136);

            Tarea t137 = new Tarea("Sembrar fresas", new DateTime(2026, 05, 25), new DateTime(1111, 11, 11), false, "", c1);
            p10.tareas.Add(t137);

            Tarea t138 = new Tarea("Regar jardines", new DateTime(2026, 06, 01), new DateTime(1111, 11, 11), false, "", c2);
            p10.tareas.Add(t138);

            Tarea t139 = new Tarea("Cosechar calabazas", new DateTime(2026, 06, 05), new DateTime(1111, 11, 11), false, "", c1);
            p10.tareas.Add(t139);

            Tarea t140 = new Tarea("Fertilizar campos", new DateTime(2026, 06, 10), new DateTime(1111, 11, 11), false, "", c2);
            p10.tareas.Add(t140);

            Tarea t141 = new Tarea("Revisar cercas", new DateTime(2026, 06, 15), new DateTime(1111, 11, 11), false, "", c1);
            p10.tareas.Add(t141);

            Tarea t142 = new Tarea("Sembrar lechugas", new DateTime(2026, 06, 20), new DateTime(1111, 11, 11), false, "", c2);
            p10.tareas.Add(t142);

            Tarea t143 = new Tarea("Limpiar establos", new DateTime(2026, 06, 25), new DateTime(1111, 11, 11), false, "", c1);
            p10.tareas.Add(t143);

            Tarea t144 = new Tarea("Recolectar huevos", new DateTime(2026, 07, 01), new DateTime(1111, 11, 11), false, "", c2);
            p10.tareas.Add(t144);

            Tarea t145 = new Tarea("Controlar malezas", new DateTime(2026, 07, 05), new DateTime(1111, 11, 11), false, "", c1);
            p10.tareas.Add(t145);

            Tarea t146 = new Tarea("Arar campos", new DateTime(2026, 07, 10), new DateTime(1111, 11, 11), false, "", c2);
            p10.tareas.Add(t146);

            Tarea t147 = new Tarea("Sembrar papas", new DateTime(2026, 07, 15), new DateTime(1111, 11, 11), false, "", c1);
            p10.tareas.Add(t147);

            Tarea t148 = new Tarea("Regar plantaciones", new DateTime(2026, 07, 20), new DateTime(1111, 11, 11), false, "", c2);
            p10.tareas.Add(t148);

            Tarea t149 = new Tarea("Podar rosales", new DateTime(2026, 07, 25), new DateTime(1111, 11, 11), false, "", c1);
            p10.tareas.Add(t149);

            Tarea t150 = new Tarea("Recolectar frutas", new DateTime(2026, 08, 01), new DateTime(1111, 11, 11), false, "", c2);
            p10.tareas.Add(t150);



            // VacunaAplicada 

            VacunaAplicada vA1 = new VacunaAplicada(v1, new DateTime(2024, 03, 15));
            b1.vacunacionesAplicadas.Add(vA1);

            VacunaAplicada vA2 = new VacunaAplicada(v3, new DateTime(2024, 03, 15));
            b1.vacunacionesAplicadas.Add(vA2);

            VacunaAplicada vA3 = new VacunaAplicada(v2, new DateTime(2024, 04,24));
            b2.vacunacionesAplicadas.Add(vA3);

            VacunaAplicada vA4 = new VacunaAplicada(v5, new DateTime(2024, 04, 24));
            b2.vacunacionesAplicadas.Add(vA4);

            VacunaAplicada vA5 = new VacunaAplicada(v2, new DateTime(2024, 04, 24));
            b2.vacunacionesAplicadas.Add(vA5);

            VacunaAplicada vA6 = new VacunaAplicada(v7, new DateTime(2024, 04, 24));
            b3.vacunacionesAplicadas.Add(vA6);

            VacunaAplicada vA7 = new VacunaAplicada(v10, new DateTime(2019, 12, 25));
            o22.vacunacionesAplicadas.Add(vA7);

            VacunaAplicada vA8 = new VacunaAplicada(v2, new DateTime(2019, 12, 25));
            o28.vacunacionesAplicadas.Add(vA8);

            VacunaAplicada vA9 = new VacunaAplicada(v7, new DateTime(2019, 12, 25));
            o23.vacunacionesAplicadas.Add(vA9);

            VacunaAplicada vA10 = new VacunaAplicada(v3, new DateTime(2019, 12, 25));
            o30.vacunacionesAplicadas.Add(vA10);

            VacunaAplicada vA11 = new VacunaAplicada(v9, new DateTime(2019, 12, 25));
            o1.vacunacionesAplicadas.Add(vA11);

            VacunaAplicada vA12 = new VacunaAplicada(v4, new DateTime(2019, 12, 25));
            o3.vacunacionesAplicadas.Add(vA12);
        }

        public List<Animal> ObtenerListaAnimales()
        {
            if (animales.Count() > 0)
            {
                return animales;
            }
            else
            {
                throw new Exception("La lista esta vacia");
            }

        }
        public List<VacunaAplicada> ObtenerVAplicada()
        {

            return vacunaciones;

        }

        public double MostrarPrecioLana()
        {
            return Ovino.precioKgLana;
        }
        public void EstablecerPrecioKgLana(double elPrecio)
        {
            Ovino.precioKgLana = elPrecio;
        }

        public List<Potrero> MostrarPotreros(double hectareas, int capMaxAnimales)
        {
            List<Potrero> potrerosFiltrados = new List<Potrero>();
            foreach (Potrero p in potreros)
            {
                if (p.cantHectareas > hectareas && p.capacidadMaxAnimales > capMaxAnimales)
                {
                    potrerosFiltrados.Add(p);
                }
            }
            return potrerosFiltrados;
        }
        public void ValidarCodigo(Bovino b)
        {
            b.Validar();
            ValidarExistenciaBovino(b);
        }
        public void AltaBovino(Bovino b)
        {
            animales.Add(b);
        }
        public void ValidarExistenciaBovino(Bovino agregar)
        {
            foreach (Animal b in animales)
            {
                if (b.Equals(agregar))
                {
                    throw new Exception("Ya existe un animal con ese ID.");
                }
            }
        }
        public void ValidarFecha(int año, int mes, int dia)
        {
            if (año % 4 == 0 && año % 100 != 0 || año % 100 == 0 && año % 400 == 0)
            {
                if (mes == 2)
                {
                    if (dia > 29)
                    {
                        throw new Exception("El dia no puede ser mayor a 29");
                    }
                }
            }
            else
            {
                if (mes == 2)
                {
                    if (dia > 28)
                    {
                        throw new Exception("El dia no puede ser mayor a 28");

                    }
                } else if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) 
                {
                    if (dia > 31)
                    {
                        throw new Exception("El dia no puede ser mayor a 31");
                    }
                } else if (mes == 4 || mes == 6 || mes == 9 || mes == 11) 
                {
                    if (dia > 30)
                    {
                        throw new Exception("El dia no puede ser mayor a 30");
                    }
                } else 
                {
                    throw new Exception("El mes no puede ser mayor a 12");
                }
            }
        }

        public void AginarAnimal(Animal animal, Potrero potrero)
        {
            potrero.Validar();
            if (animal.esLibre)
            {
                animal.esLibre = false;
                potrero.animalesPastando.Add(animal);
            }
        }

        public void AsignarYCrearTarea(string descripcion, DateTime fechaPactada, Capataz capataz, Peon peon) 
        {
            Tarea t = new Tarea(descripcion, fechaPactada, capataz);
            peon.tareas.Add(t);
        }
        public void AsignarTarea(Tarea tarea, Peon peon)
        {
            peon.tareas.Add(tarea);
        }
    }
}


