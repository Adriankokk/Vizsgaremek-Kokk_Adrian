<?php

$eredmeny = "";
$nev = "";

if (isset($_GET["nev"])) {

    $nev = trim($_GET["nev"]);

    if ($nev != "") {

        try {

            $pdo = new PDO(
                "mysql:host=192.168.1.11;dbname=nevnap;charset=utf8mb4",
                "nevnap_osztaly",
                "Birok2027"
            );

            $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

            $sql = "SELECT honap, nap FROM nevnap WHERE nev = ?";

            $lekerdezes = $pdo->prepare($sql);

            $lekerdezes->execute([$nev]);

            $talalatok = $lekerdezes->fetchAll(PDO::FETCH_ASSOC);

            if (count($talalatok) > 0) {

                foreach ($talalatok as $sor) {

                    $eredmeny .= htmlspecialchars($sor["honap"]) .
                    ". hónap " .
                    htmlspecialchars($sor["nap"]) .
                    ". nap<br>";

                }

            } else {

                $eredmeny = "Nincs ilyen név az adatbázisban!";

            }

        } catch (PDOException $e) {

            $eredmeny = "Adatbázis-kapcsolati hiba!";

        }

    } else {

        $eredmeny = "Kérlek, adj meg egy nevet!";

    }

}

?>

<!DOCTYPE html>
<html lang="hu">

<head>

    <meta charset="UTF-8">

    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>Névnapkereső</title>

    <link rel="stylesheet" href="style.css">

</head>

<body>

    <div class="container">

        <div class="ikon">📅</div>

        <h1>Névnapkereső</h1>

        <p class="leiras">
            Keresd meg, mikor van a névnapod!
        </p>

        <form method="GET">

            <label for="nev">Keresztnév:</label>

            <input
                type="text"
                id="nev"
                name="nev"
                placeholder="Írd be a keresztneved..."
                value="<?php echo htmlspecialchars($nev); ?>"
                required
            >

            <button type="submit">Keresés</button>

        </form>

        <?php if ($eredmeny != ""): ?>

            <div class="eredmeny">

                <h3>Keresés eredménye</h3>

                <p><?php echo $eredmeny; ?></p>

            </div>

        <?php endif; ?>

    </div>

</body>

</html>


#http://localhost/nevnap/index.php?nev