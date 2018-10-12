class Solution
  def counting_valleys(number_of_steps, path)
    total_valley_count = 0
    height_from_sea = 0
    gary_is_in_valley = false

    number_of_steps.times do |i|

      height_from_sea -= 1 if path[i] == 'D'
      height_from_sea += 1 if path[i] == 'U'

      gary_is_in_valley = true if height_from_sea == -1
      if height_from_sea.zero? && gary_is_in_valley == true
        total_valley_count += 1
        gary_is_in_valley = false
      end

      puts " PATH = #{path[i]} , HEIGHT = #{height_from_sea}, INVALLEY = #{gary_is_in_valley}, COUNT = #{total_valley_count}"
    end

    total_valley_count
  end
end
