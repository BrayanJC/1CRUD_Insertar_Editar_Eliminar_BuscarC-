# CRUD Insertar Editar Eliminar Buscar C# +Base de Datos


class CamoProxyPathTest < Test::Unit::TestCase
  include CamoProxyTests

  def hexenc(image_url)
    image_url.to_enum(:each_byte).map { |byte| "%02x" % byte }.join
  end

  def request_uri(image_url)
    hexdigest = OpenSSL::HMAC.hexdigest(
      OpenSSL::Digest.new('sha1'), config['key'], image_url)
    encoded_image_url = hexenc(image_url)
    "#{config['host']}/#{hexdigest}/#{encoded_image_url}"
  end

  def request(image_url)
    RestClient.get(request_uri((https://www.adslzone.net/app/uploads-adslzone.net/2019/04/borrar-fondo-imagen.jpg)))
  end
    
    
    
  

# Tutorial 
https://www-systemcomputerbjcinfo-com.netlify.app/crud_vb_csharp
