$ip  = $args[1]

if ($ip -eq $null )
{
    echo " "
    echo "Debe usar el argumento -ip"
    echo " "
    Start-Sleep -s 2
    echo "./xPorts -ip 192.168.0.1"
    echo " "
    Start-Sleep -s 2
    exit
}

$portrange = 1..65535
$range = 1..20
$timeout_ms = 5

        echo " "
        echo "Checking ports for --> $ip"
        echo " "

        ping -n 1 -w 10 "$ip" > NULL | Select-String "recibidos = 1";
        echo "[*]Recuerda pulsar ENTER en el CMD para ejercer presión en la carga de datos (output)."
    
 
        foreach ($port in $portrange)
        {
            $ErrorActionPreference = 'SilentlyContinue'
            $socket = new-object System.Net.Sockets.TcpClient
            $connect = $socket.BeginConnect($ip, $port, $null, $null)
            $tryconnect = Measure-Command { $success = $connect.AsyncWaitHandle.WaitOne($timeout_ms, $true) } | % totalmilliseconds
            $tryconnect | Out-Null
 
            if ($socket.Connected)
            {
                "$ip is listening on port $port (Response Time: $tryconnect ms)"
                $socket.Close()
                $socket.Dispose()
                $socket = $null
            }
 
            $ErrorActionPreference = 'Continue'
        }
