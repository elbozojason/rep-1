def activitas   (cuaca='mendung',suhu='panas',jalan='tidakmacet'):
     if     (cuaca=='cerah' and suhu!='panas' and jalan=='tidakmacet'):
          return'jalan di taman'
     elif    ((cuaca!='cerah' or suhu=='panas') and jalan=='tidakmacet'):
          return'jalan di mall'
     elif    (jalan=='macet'):
          return'diam di rumah'
activitas   ()
print(activitas())
