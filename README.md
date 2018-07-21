# ADSExamenFinal-SubirNota

# Endpoints:

# Estudiantes de Doctorado
https://subirnota-ads-examenfinal-api-shiny-swan.cfapps.io/api/Students/findByType?studentType=Doctorado

# Estudiantes de Maestría
https://subirnota-ads-examenfinal-api-shiny-swan.cfapps.io/api/Students/findByType?studentType=Maestria

# Estudiantes de Pregrado
https://subirnota-ads-examenfinal-api-shiny-swan.cfapps.io/api/Students/findByType?studentType=Pregrado

# Todos los estudiantes
https://subirnota-ads-examenfinal-api-shiny-swan.cfapps.io/api/Students

# Calcular el monto de la beca por código de estudiante

# Pregrado
https://subirnota-ads-examenfinal-api-shiny-swan.cfapps.io/api/Students/getScholarshipAmount?studentCode=Code1

# Maestría
https://subirnota-ads-examenfinal-api-shiny-swan.cfapps.io/api/Students/getScholarshipAmount?studentCode=Code101

# Doctorado
https://subirnota-ads-examenfinal-api-shiny-swan.cfapps.io/api/Students/getScholarshipAmount?studentCode=Code201

# Estudiante inexistente
https://subirnota-ads-examenfinal-api-shiny-swan.cfapps.io/api/Students/getScholarshipAmount?studentCode=Code1xxxxxxx

Respuesta:

{"response":{"httpStatus":400,"errors":[{"message":"The student code doesn't exist"}]}}