﻿namespace FSharp.Karma

type PlusEmpty<'F> =
  inherit Plus<'F>
  abstract member Empty: unit -> #_1<'F, 'A>
