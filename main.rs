fn main() {
    // --- 4 TIMES INICIAIS ---
    let mut times: Vec<String> = vec![
        String::from("Atlético-MG"),
        String::from("Cruzeiro"),
        String::from("América-MG"),
        String::from("Villa Nova"),
    ];

    // Exibir os times com seus índices
    println!("=== Times Cadastrados ===");
    for (i, time) in times.iter().enumerate() {
        println!("{} - {}", i, time);
    }

    // Jogos de ida e volta
    println!("\n=== Jogos de Ida e Volta (4 Times) ===");
    let mut total_ida_volta = 0;
    for i in 0..times.len() {
        for j in 0..times.len() {
            if i != j {
                println!("{} x {}", times[i], times[j]);
                total_ida_volta += 1;
            }
        }
    }
    println!("Total de jogos de ida e volta: {}", total_ida_volta);

    // Turno único
    println!("\n=== Turno Único (4 Times) ===");
    let mut total_turno_unico = 0;
    for i in 0..times.len() {
        for j in (i + 1)..times.len() {
            println!("{} x {}", times[i], times[j]);
            total_turno_unico += 1;
        }
    }
    println!("Total de jogos em turno único: {}", total_turno_unico);

    // --- ALTERAÇÃO DA COLEÇÃO (INCLUIR TOMBENSE) ---
    println!("\n=== Adicionando Tombense no Rust ===");
    times.push(String::from("Tombense"));

    println!("\n--- Tabela Recalculada com 5 Times (Ida e Volta) ---");
    total_ida_volta = 0;
    for i in 0..times.len() {
        for j in 0..times.len() {
            if i != j {
                println!("{} x {}", times[i], times[j]);
                total_ida_volta += 1;
            }
        }
    }
    println!(
        "Total de jogos de ida e volta (5 times): {}",
        total_ida_volta
    );

    println!("\n--- Tabela Recalculada com 5 Times (Turno Único) ---");
    total_turno_unico = 0;
    for i in 0..times.len() {
        for j in (i + 1)..times.len() {
            println!("{} x {}", times[i], times[j]);
            total_turno_unico += 1;
        }
    }
    println!(
        "Total de jogos em turno único (5 times): {}",
        total_turno_unico
    );
}
