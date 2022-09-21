/*
 Sukurti struktūrą Saskaita. Publiclaukai gavejas, siuntejas, moketiViso, saskaitosNumeris. 
Visi laukai tik skaitymui, perduodami per konstruktorių išskyrus saskaitosNumeris, 
jis generuojasi automatiškai konstruktoriuje (NR_metai_menuo_diena_01)
 * */

using Lesson08Saskaita;

Saskaita uzMaista = new Saskaita("Tomas", "As", 1);

Console.WriteLine(uzMaista.SaskaitosNumeris);