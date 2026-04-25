import socket
import sys
from concurrent.futures import ThreadPoolExecutor
import subprocess
import platform
hedef = sys.argv[1] if len(sys.argv) > 1 else "127.0.0.1"
baslangic = int(sys.argv[2]) if len(sys.argv) > 2 else 1
bitis = int(sys.argv[3]) if len(sys.argv) > 3 else 1024
work = int(sys.argv[4]) if len(sys.argv) > 4  else 100
timeout = float(sys.argv[5]) if len(sys.argv) > 5  else 0.3
servis_tarama = sys.argv[6].lower() == 'true' if len(sys.argv) > 6 else False

def ping_kontrol(hedef):
    sistem = platform.system().lower()
    if sistem == "windows":
        komut = ["ping", "-n", "1", "-w", "1000", hedef]
    else:
        komut = ["ping", "-c", "1", "-W", "1", hedef]
    
    try:
        sonuc = subprocess.run(komut, stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
        return sonuc.returncode == 0
    except:
        return False
sys.stdout.write("|PING kontrol ediliyor...\n")
sys.stdout.flush()

if not ping_kontrol(hedef):
    sys.stdout.write("|PING_BASARISIZ|\n")
    sys.stdout.flush()
    sys.exit(0)

sys.stdout.write("|PING_OK|\n")
sys.stdout.flush()

def tara(port):
    try:
        
        with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
            s.settimeout(timeout)
            if s.connect_ex((hedef, port)) == 0:
                if servis_tarama == True:
                    servis = "Bilinmiyor"
                    try:
                        # Bazı servisler bağlanınca doğrudan banner gönderir (SSH, FTP, SMTP)
                        banner = s.recv(1024).decode().strip()
                        if banner:
                            servis = banner
                        else:
                            # Bazı servisler için (HTTP gibi) bir veri göndermen gerekir
                            s.send(b"HEAD / HTTP/1.1\r\nHost: " + hedef.encode() + b"\r\n\r\n")
                            banner = s.recv(1024).decode().strip()
                            if banner: servis = banner.split('\n')[0] # Sadece ilk satır
                    except:
                        # Banner alınamazsa standart servis ismini socket üzerinden almayı dene
                        try:
                            servis = socket.getservbyport(port, "tcp")
                        except:
                            pass
                if servis_tarama == True:
                    sys.stdout.write(f"|ACIK:{port} | [{servis}]\n")
                else:
                    sys.stdout.write(f"|ACIK:{port}\n")
    except: 
        pass
    finally:
        sys.stdout.write("P")
        sys.stdout.flush()

with ThreadPoolExecutor(max_workers=work) as executor:
    executor.map(tara, range(baslangic, bitis + 1))

# Tarama tamamen bittiğinde sinyal gönder
sys.stdout.write("|BITTI|\n")
sys.stdout.flush()