Materia: Programació Avanzada
Módulo: 1/2025

# Comandos de Gestión en Linux y Control de Versiones con Git

## 1️⃣ Gestión de Archivos en Linux
Estos comandos permiten gestionar directorios y archivos en sistemas Linux.

### 📌 `pwd` (Print Working Directory)
Muestra el directorio en el que te encuentras actualmente.
```sh
pwd
```
🔹 Ejemplo de salida:
```
/home/usuario
```

### 📌 `ls -la` (Listar archivos y directorios con detalles)
Muestra todos los archivos, incluyendo ocultos, con detalles como permisos y propietario.
```sh
ls -la
```
🔹 Ejemplo de salida:
```
-rw-r--r--  1 usuario usuario 4096 Feb 5 10:00 archivo.txt
```

### 📌 `mkdir` (Crear un directorio)
Crea un nuevo directorio en la ubicación actual.
```sh
mkdir mi_carpeta
```

### 📌 `cd` (Cambiar de directorio)
Permite moverse entre directorios.
```sh
cd mi_carpeta
```
Para volver atrás:
```sh
cd ..
```

### 📌 `rm -rf` (Eliminar archivos y carpetas de forma recursiva y forzada)
Este comando elimina archivos y directorios de forma irreversible.
```sh
rm -rf mi_carpeta
```
⚠️ **Precaución**: Usa este comando con cuidado, ya que no se pueden recuperar los archivos eliminados.

---

## 2️⃣ Control de Versiones con Git
Estos comandos permiten gestionar repositorios con Git de manera eficiente.

### 📌 `git --version` (Ver la versión instalada de Git)
Muestra la versión de Git instalada en el sistema.
```sh
git --version
```
🔹 Ejemplo de salida:
```
git version 2.34.1
```

### 📌 `git status` (Ver el estado del repositorio)
Muestra los cambios pendientes de confirmación en el repositorio.
```sh
git status
```

### 📌 `git clone` (Clonar un repositorio remoto)
Copia un repositorio de Git desde un servidor remoto a tu equipo local.
```sh
git clone https://github.com/usuario/repositorio.git
```

### 📌 `git branch` (Gestionar ramas del repositorio)
Muestra las ramas disponibles en el repositorio.
```sh
git branch
```
Para crear una nueva rama:
```sh
git branch nueva_rama
```

### 📌 `git log` (Ver historial de commits)
Muestra un historial de commits en el repositorio.
```sh
git log
```

### 📌 `git add` (Añadir archivos al área de preparación)
Prepara los archivos para ser confirmados en el próximo commit.
```sh
git add archivo.txt
```
Para agregar todos los archivos:
```sh
git add .
```

### 📌 `git fetch` (Obtener cambios del repositorio remoto)
Descarga cambios del repositorio remoto sin fusionarlos.
```sh
git fetch
```

### 📌 `git push` (Enviar cambios al repositorio remoto)
Sube los commits locales al repositorio remoto.
```sh
git push origin main
```

---

✅ Con estos comandos, puedes gestionar eficientemente archivos en Linux y controlar versiones con Git.

