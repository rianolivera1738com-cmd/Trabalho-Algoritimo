public class App {
    public static void main(String[] args) throws Exception {
        // --- 4 TIMES INICIAIS ---
        String[] times = {"Atlético-MG", "Cruzeiro", "América-MG", "Villa Nova"};

        // Exibir os times com seus índices
        System.out.println("=== Times Cadastrados ===");
        for (int i = 0; i < times.length; i++) {
            System.out.println(i + " - " + times[i]);
        }

        // Gerar e contar confrontos de ida e volta
        System.out.println("\n=== Jogos de Ida e Volta (4 Times) ===");
        int totalIdaVolta = 0;
        for (int i = 0; i < times.length; i++) {
            for (int j = 0; j < times.length; j++) {
                if (i != j) {
                    System.out.println(times[i] + " x " + times[j]);
                    totalIdaVolta++;
                }
            }
        }
        System.out.println("Total de jogos de ida e volta: " + totalIdaVolta);

        // Gerar e contar confrontos em turno único
        System.out.println("\n=== Jogos em Turno Único (4 Times) ===");
        int totalTurnoUnico = 0;
        for (int i = 0; i < times.length; i++) {
            for (int j = i + 1; j < times.length; j++) {
                System.out.println(times[i] + " x " + times[j]);
                totalTurnoUnico++;
            }
        }
        System.out.println("Total de jogos em turno único: " + totalTurnoUnico);

        // --- ALTERAÇÃO DA COLEÇÃO (INCLUIR TOMBENSE) ---
        System.out.println("\n=== Adicionando Tombense no Java ===");
        String[] novosTimes = new String[5];
        for (int i = 0; i < times.length; i++) {
            novosTimes[i] = times[i];
        }
        novosTimes[4] = "Tombense";
        times = novosTimes;

        System.out.println("\n--- Tabela Recalculada com 5 Times (Ida e Volta) ---");
        totalIdaVolta = 0;
        for (int i = 0; i < times.length; i++) {
            for (int j = 0; j < times.length; j++) {
                if (i != j) {
                    System.out.println(times[i] + " x " + times[j]);
                    totalIdaVolta++;
                }
            }
        }
        System.out.println("Total de jogos de ida e volta (5 times): " + totalIdaVolta);

        System.out.println("\n--- Tabela Recalculada com 5 Times (Turno Único) ---");
        totalTurnoUnico = 0;
        for (int i = 0; i < times.length; i++) {
            for (int j = i + 1; j < times.length; j++) {
                System.out.println(times[i] + " x " + times[j]);
                totalTurnoUnico++;
            }
        }
        System.out.println("Total de jogos em turno único (5 times): " + totalTurnoUnico);
    }
}
